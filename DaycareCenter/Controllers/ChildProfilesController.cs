using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DaycareCenter.Models;

namespace DaycareCenter.Controllers
{
    public class ChildProfilesController : Controller
    {
        private readonly AppDbContext _context;

        public ChildProfilesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: ChildProfiles
        public async Task<IActionResult> Index()
        {
            return View(await _context.ChildProfile.ToListAsync());
        }

        // GET: ChildProfiles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var childProfile = await _context.ChildProfile
                .FirstOrDefaultAsync(m => m.Child_Id == id);
            if (childProfile == null)
            {
                return NotFound();
            }

            return View(childProfile);
        }

        // GET: ChildProfiles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ChildProfiles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Child_Id,Child_Name,Age,Gender,Religion,Phone,Address")] ChildProfile childProfile)
        {
            if (ModelState.IsValid)
            {
                _context.Add(childProfile);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(childProfile);
        }

        // GET: ChildProfiles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var childProfile = await _context.ChildProfile.FindAsync(id);
            if (childProfile == null)
            {
                return NotFound();
            }
            return View(childProfile);
        }

        // POST: ChildProfiles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Child_Id,Child_Name,Age,Gender,Religion,Phone,Address")] ChildProfile childProfile)
        {
            if (id != childProfile.Child_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(childProfile);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChildProfileExists(childProfile.Child_Id))
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
            return View(childProfile);
        }

        // GET: ChildProfiles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var childProfile = await _context.ChildProfile
                .FirstOrDefaultAsync(m => m.Child_Id == id);
            if (childProfile == null)
            {
                return NotFound();
            }

            return View(childProfile);
        }

        // POST: ChildProfiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var childProfile = await _context.ChildProfile.FindAsync(id);
            _context.ChildProfile.Remove(childProfile);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChildProfileExists(int id)
        {
            return _context.ChildProfile.Any(e => e.Child_Id == id);
        }
    }
}
