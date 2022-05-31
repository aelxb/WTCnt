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
using System.Security.Claims;

namespace WTCnt.Controllers
{
    public class TasksController : Controller
    {
        private readonly TaskContext _context;
        public TasksController(TaskContext context)
        {
            _context = context;
        }

        // GET: Tasks
        [Authorize(Roles = "Программист,Тестировщик, Ведущий программист, Ведущий тестировщик, Администратор")]
        public async Task<IActionResult> Index()
        {
            Task task = _context.Task.ToList().Find(m => m.EndDate == null&&m.Type!="Работа");
            MainViewModel model = new MainViewModel();
            if (task == null)
            {
                model = new MainViewModel { Task = new Task(), Tasks = _context.Task.ToList().FindAll(t => t.Type!="Работа"&&t.UserOwner== int.Parse(HttpContext.User.Identities.ToList()[0].Name)) , IsActiveTaskExists = false};
            }
            else
            {
                model = new MainViewModel { Task = task, Tasks = _context.Task.ToList().FindAll(t => t.Type != "Работа" && t.UserOwner == int.Parse(HttpContext.User.Identities.ToList()[0].Name)), IsActiveTaskExists = true};
            }
            return View(model);
        }
        // GET: Tasks/Details/5
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

        [HttpPost]
        public async Task<IActionResult> Create(Task task)
        {
            task.CreationDate = DateTime.Now;
            List<ClaimsIdentity> claims = HttpContext.User.Identities.ToList();
            task.UserOwner = int.Parse(HttpContext.User.Identities.ToList()[0].Name);
            task.EndDate = null;
            _context.Task.Add(task);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        // GET: Tasks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var task = await _context.Task.FindAsync(id);
            if (task == null)
            {
                return NotFound();
            }
            return View(task);
        }

        // POST: Tasks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id)
        {
            var task = await _context.Task.FindAsync(id);
            task.EndDate = DateTime.Now;
            try
            {
                _context.Update(task);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TaskExists(task.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: Tasks/Delete/5
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

        // POST: Tasks/Delete/5
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
