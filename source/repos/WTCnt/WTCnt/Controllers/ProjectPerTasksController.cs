using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WTCnt.Models;

namespace WTCnt.Controllers
{
    public class ProjectPerTasksController : Controller
    {
        private readonly ProjectPerTaskContext _context;
        private readonly UsrContext _usrContext;
        private readonly PrjectContext _pContext;
        private readonly TaskContext _tContext;
        public ProjectPerTasksController(ProjectPerTaskContext context, UsrContext usr, PrjectContext prject, TaskContext task)
        {
            _context = context;
            _usrContext = usr;
            _pContext = prject;
            _tContext = task;
        }

        // GET: ProjectPerTasks
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProjectPerTasks.ToListAsync());
        }

        // GET: ProjectPerTasks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectPerUser = await _context.ProjectPerTasks
                .FirstOrDefaultAsync(m => m.ID_project == id);
            if (projectPerUser == null)
            {
                return NotFound();
            }

            return View(projectPerUser);
        }

        // GET: ProjectPerTasks/Create
        public IActionResult Create(int pId)
        {
            PpUViewModel vmodel = new PpUViewModel();
            vmodel.Users = _usrContext.User;
            vmodel.ProjectID = pId;
            return View(vmodel);
        }

        // POST: ProjectPerTasks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int projectID, int user, string comment)
        {
            ProjectPerTask projectPerTask = new ProjectPerTask();
            Models.Task task = new Models.Task();
            task.Comment = comment;
            task.UserOwner = user;
            task.EndDate = _pContext.Project.ToList().Find(x => x.ID == projectID).EndDate;
            task.CreationDate = DateTime.Now;
            task.Done = 0;
            task.Type = "Работа";
            _tContext.Add(task);
            await _tContext.SaveChangesAsync();
            projectPerTask.ID_Task = task.ID;
            projectPerTask.ID_project = projectID;
            _context.Add(projectPerTask);
            await _context.SaveChangesAsync();
            return RedirectToAction("Create", "ProjectPerTasks", new { pId = projectPerTask.ID_project});
        }

        // GET: ProjectPerTasks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectPerUser = await _context.ProjectPerTasks.FindAsync(id);
            if (projectPerUser == null)
            {
                return NotFound();
            }
            return View(projectPerUser);
        }

        // POST: ProjectPerTasks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID_project,ID_User,Done")] ProjectPerTask projectPerUser)
        {
            if (id != projectPerUser.ID_project)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projectPerUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectPerUserExists(projectPerUser.ID_project))
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
            return View(projectPerUser);
        }

        // GET: ProjectPerTasks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectPerUser = await _context.ProjectPerTasks
                .FirstOrDefaultAsync(m => m.ID_project == id);
            if (projectPerUser == null)
            {
                return NotFound();
            }

            return View(projectPerUser);
        }

        // POST: ProjectPerTasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var projectPerUser = await _context.ProjectPerTasks.FindAsync(id);
            _context.ProjectPerTasks.Remove(projectPerUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjectPerUserExists(int id)
        {
            return _context.ProjectPerTasks.Any(e => e.ID_project == id);
        }
    }
}
