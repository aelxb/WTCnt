using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WTCnt.Models;

namespace WTCnt.Controllers
{
    public class UsrsController : Controller
    {
        private readonly UsrContext _context;

        public UsrsController(UsrContext context)
        {
            _context = context;
        }

        // GET: Usrs
        public async Task<IActionResult> Index()
        {
            return View(await _context.User.ToListAsync());
        }
        // GET: Usrs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usr = await _context.User
                .FirstOrDefaultAsync(m => m.ID == id);
            if (usr == null)
            {
                return NotFound();
            }

            return View(usr);
        }

        // GET: Usrs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Usrs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,DomenName,Password,Name,Surname,Role,Photo")] Usr usr, IFormFile uploadImage)
        {
            if (ModelState.IsValid)
            {
                byte[] imageData = null;
                if (uploadImage != null)
                    using (var binaryReader = new BinaryReader(uploadImage.OpenReadStream()))
                    {
                        imageData = binaryReader.ReadBytes((int)uploadImage.Length);
                    }
                usr.Photo = imageData;
                _context.Add(usr);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: Usrs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usr = await _context.User.FindAsync(id);
            if (usr == null)
            {
                return NotFound();
            }
            return View(usr);
        }

        // POST: Usrs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,DomenName,Password,Name,Surname,Role,Photo")] Usr usr, IFormFile uploadImage)
        {
            if (id != usr.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    byte[] imageData = null;
                    if (uploadImage != null)
                        using (var binaryReader = new BinaryReader(uploadImage.OpenReadStream()))
                        {
                            imageData = binaryReader.ReadBytes((int)uploadImage.Length);
                        }
                    usr.Photo = imageData;
                    _context.Update(usr);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsrExists(usr.ID))
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
            return View(usr);
        }

        // GET: Usrs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usr = await _context.User
                .FirstOrDefaultAsync(m => m.ID == id);
            if (usr == null)
            {
                return NotFound();
            }

            return View(usr);
        }

        // POST: Usrs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usr = await _context.User.FindAsync(id);
            _context.User.Remove(usr);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsrExists(int id)
        {
            return _context.User.Any(e => e.ID == id);
        }
    }
}
