using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WTCnt.Models;

namespace WTCnt.Controllers
{
    public class PrjectsController : Controller
    {
        private readonly PrjectContext _context;
        private readonly UsrContext _usrContext;
        private readonly MessageContext messageContext;
        private readonly ProjectPerTaskContext _ppuContext;
        private readonly TaskContext _tContext;
        public static int prid;
        public PrjectsController(PrjectContext context, UsrContext usr, ProjectPerTaskContext ppu, MessageContext mc, TaskContext t)
        {
            messageContext = mc;
            _context = context;
            _usrContext = usr;
            _ppuContext = ppu;
            _tContext = t;
        }
        //[Authorize(Roles = "Ведущий программист,Администратор")]
        // GET: Prjects
        public async Task<IActionResult> Index()
        {
            ProjectsViewModel model = new ProjectsViewModel();
            model.Users = _usrContext.User;
            model.Prjects = await _context.Project.ToListAsync();
            model.messages = messageContext.Message;
            return View(model);
        }
        public async Task<IActionResult> ViewForUser()
        {
            ProjectsViewModel model = new ProjectsViewModel();
            model.Users = _usrContext.User;
            model.Prjects = await _context.Project.ToListAsync();
            model.messages = messageContext.Message;
            model.ProjectPerTasks = _ppuContext.ProjectPerTasks.ToList();
            return View(model);
        }
        [HttpPost]
        public ActionResult Chat()
        {
            ProjectsViewModel empList = new ProjectsViewModel();;
            empList.Users = _usrContext.User;
            empList.messages = messageContext.Message;
            return PartialView("_Chat",empList);
        }
        // GET: Prjects/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prject = await _context.Project
                .FirstOrDefaultAsync(m => m.ID == id);
            if (prject == null)
            {
                return NotFound();
            }
            ProjectsViewModel model = new ProjectsViewModel();
            model.ProjectPerTasks = _ppuContext.ProjectPerTasks.ToList().FindAll(ppu => ppu.ID_project == id);
            model.tasks = new List<Models.Task>();
            foreach (ProjectPerTask perTask in model.ProjectPerTasks)
                model.tasks.Add(_tContext.Task.ToList().Find(x=>x.ID==perTask.ID_Task));
            model.Users = _usrContext.User;
            model.Prject = prject;
            model.messages = messageContext.Message;
            prid = (int)id;
            return View(model);
        }

        // GET: Prjects/Create
        public IActionResult Create()
        {
            ProjectsViewModel model = new ProjectsViewModel();
            model.Users = _usrContext.User;
            return View(model);
        }

        // POST: Prjects/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,EndDate,CreationDate,UserOwner")] Prject prject)
        {
            if (ModelState.IsValid)
            {
                prject.CreationDate = DateTime.Now;
                _context.Add(prject);
                await _context.SaveChangesAsync();
                return RedirectToAction("Create", "ProjectPerTasks", new { pId = prject.ID });
            }
            return View(prject);
        }

        // GET: Prjects/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prject = await _context.Project.FindAsync(id);
            if (prject == null)
            {
                return NotFound();
            }
            return View(prject);
        }

        // POST: Prjects/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,EndDate,CreationDate,UserOwner")] Prject prject)
        {
            if (id != prject.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prject);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrjectExists(prject.ID))
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
            return View(prject);
        }

        // GET: Prjects/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prject = await _context.Project
                .FirstOrDefaultAsync(m => m.ID == id);
            if (prject == null)
            {
                return NotFound();
            }

            return View(prject);
        }

        // POST: Prjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var prject = await _context.Project.FindAsync(id);
            _context.Project.Remove(prject);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PrjectExists(int id)
        {
            return _context.Project.Any(e => e.ID == id);
        }
        [HttpPost]
        public async Task<EmptyResult> SendMessage([Bind("messText")] string messText)
        {
            Message message = new Message();
            message.Text = messText;
            message.TimeSend = DateTime.Now;
            message.User_ID = int.Parse(User.Identities.ToList()[0].Name);
            message.Project_ID = prid;
            messageContext.Add(message);
            await messageContext.SaveChangesAsync();
            return new EmptyResult();
        }
    }
}
