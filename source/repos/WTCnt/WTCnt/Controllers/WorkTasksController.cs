using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WTCnt.Models;
using Task = WTCnt.Models.Task;

namespace WTCnt.Controllers
{
    public class WorkTasksController : Controller
    {
        private readonly TaskContext _context;
        private readonly UsrContext _usrContext;
        public WorkTasksController(TaskContext context, UsrContext usr)
        {
            _context = context;
            _usrContext = usr;
        }

        // GET: Tasks
        public async Task<IActionResult> Index(int? id)
        {
            if (_context.Task.ToList().Find(t => t.EndDate == null && t.Type != "Работа" && t.UserOwner == int.Parse(HttpContext.User.Identities.ToList()[0].Name)) == null)
            {
                MainViewModel model = new MainViewModel();
                var tasks = _context.Task.ToList().FindAll(t => t.Type == "Работа" && t.UserOwner == int.Parse(HttpContext.User.Identities.ToList()[0].Name));
                List<Task> t = tasks;
                switch (id)
                {
                    case 1:
                        t = tasks.OrderBy(t => t.CreationDate).ToList();
                        break;
                    case 2:
                        t = tasks.OrderBy(t => t.EndDate).ToList();
                        break;
                    case 3:
                        t = tasks.OrderBy(t => t.Comment).ToList();
                        break;
                    case 4:
                        t = tasks.OrderBy(t => t.Done).ToList();
                        break;
                }
                model = new MainViewModel { Task = new Task(), Tasks = t, IsActiveTaskExists = false };
                return View(model);
            }
            else
            {
                return RedirectToAction("Chill");
            }
        }
        public async Task<IActionResult> IndexForAdmin(int? id)
        {
            MainViewModel model = new MainViewModel();
            var tasks = _context.Task.ToList().FindAll(t => t.Type == "Работа");
            List<Task> t = tasks;
            if (id != null)
            {
                switch (id)
                {
                    case 1:
                        t = tasks.OrderBy(t => t.CreationDate).ToList();
                        break;
                    case 2:
                        t = tasks.OrderBy(t => t.EndDate).ToList();
                        break;
                    case 3:
                        t = tasks.OrderBy(t => t.Comment).ToList();
                        break;
                    case 4:
                        t = tasks.OrderBy(t => t.Done).ToList();
                        break;
                    case 5:
                        IEnumerable<Usr> usrs = _usrContext.User.OrderBy(u=>u.Surname);
                        foreach(var u in usrs)
                        {
                            t.AddRange(tasks.FindAll(t => t.UserOwner == u.ID));
                        }
                        break;
                }
            }

            model = new MainViewModel { Task = new Task(), Tasks = t, IsActiveTaskExists = false, Users = _usrContext.User };
            return View(model);
        }

        // GET: WorkTasks/Chill
        public async Task<IActionResult> Chill()
        {
            return View();
        }
        // GET: WorkTasks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var task = await _context.Task
                .FirstOrDefaultAsync(m => m.ID == id);
            if (task == null)
            {
                return NotFound();
            }

            return View(task);
        }

        // GET: WorkTasks/Create
        public IActionResult Create()
        {
            WorkTaskModel model = new WorkTaskModel();
            model.Users = _usrContext.User.ToList();
            model.Task = new Task();
            return View(model);
        }

        // POST: WorkTasks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,CreationDate,EndDate,Comment,Type,UserOwner")] Task task)
        {
            if (ModelState.IsValid)
            {
                task.CreationDate = DateTime.Now;
                task.Type = "Работа";
                task.Done = 0;
                _context.Add(task);
                await _context.SaveChangesAsync();
                if (User.IsInRole("Администратор"))
                    return RedirectToAction("Index", "Home");
                else
                    return RedirectToAction(nameof(Index));
            }
            return View(task);
        }

        // GET: WorkTasks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var task = await _context.Task.FindAsync(id);
            task.Done = 2;
            _context.Update(task);
            await _context.SaveChangesAsync();
            if (task == null)
            {
                return NotFound();
            }
            return RedirectToAction("Index");
        }
        // GET: WorkTasks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var task = await _context.Task
                .FirstOrDefaultAsync(m => m.ID == id);
            if (task == null)
            {
                return NotFound();
            }

            return View(task);
        }

        // POST: WorkTasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var task = await _context.Task.FindAsync(id);
            _context.Task.Remove(task);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TaskExists(int id)
        {
            return _context.Task.Any(e => e.ID == id);
        }
    }
}
