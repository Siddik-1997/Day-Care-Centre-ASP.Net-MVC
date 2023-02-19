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
    public class NanyProfilesController : Controller
    {
        private readonly AppDbContext _context;

        public NanyProfilesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: NanyProfiles
        public async Task<IActionResult> Index()
        {
            return View(await _context.NanyProfile.ToListAsync());
        }

        // GET: NanyProfiles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nanyProfile = await _context.NanyProfile
                .FirstOrDefaultAsync(m => m.Nany_Id == id);
            if (nanyProfile == null)
            {
                return NotFound();
            }

            return View(nanyProfile);
        }

        // GET: NanyProfiles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NanyProfiles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nany_Id,Nany_Name,NAge,NGender,NReligion,NPhone,NAddress")] NanyProfile nanyProfile)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nanyProfile);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nanyProfile);
        }

        // GET: NanyProfiles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nanyProfile = await _context.NanyProfile.FindAsync(id);
            if (nanyProfile == null)
            {
                return NotFound();
            }
            return View(nanyProfile);
        }

        // POST: NanyProfiles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Nany_Id,Nany_Name,NAge,NGender,NReligion,NPhone,NAddress")] NanyProfile nanyProfile)
        {
            if (id != nanyProfile.Nany_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nanyProfile);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NanyProfileExists(nanyProfile.Nany_Id))
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
            return View(nanyProfile);
        }

        // GET: NanyProfiles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nanyProfile = await _context.NanyProfile
                .FirstOrDefaultAsync(m => m.Nany_Id == id);
            if (nanyProfile == null)
            {
                return NotFound();
            }

            return View(nanyProfile);
        }

        // POST: NanyProfiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nanyProfile = await _context.NanyProfile.FindAsync(id);
            _context.NanyProfile.Remove(nanyProfile);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NanyProfileExists(int id)
        {
            return _context.NanyProfile.Any(e => e.Nany_Id == id);
        }
    }
}
