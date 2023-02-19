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
    public class NanySchedulesController : Controller
    {
        private readonly AppDbContext _context;

        public NanySchedulesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: NanySchedules
        public async Task<IActionResult> Index()
        {
            return View(await _context.NanySchedule.ToListAsync());
        }

        // GET: NanySchedules/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nanySchedule = await _context.NanySchedule
                .FirstOrDefaultAsync(m => m.Schedule_Id == id);
            if (nanySchedule == null)
            {
                return NotFound();
            }

            return View(nanySchedule);
        }

        // GET: NanySchedules/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NanySchedules/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Schedule_Id,Shift_Id,Nany_Id,Child_Id")] NanySchedule nanySchedule)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nanySchedule);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nanySchedule);
        }

        // GET: NanySchedules/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nanySchedule = await _context.NanySchedule.FindAsync(id);
            if (nanySchedule == null)
            {
                return NotFound();
            }
            return View(nanySchedule);
        }

        // POST: NanySchedules/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Schedule_Id,Shift_Id,Nany_Id,Child_Id")] NanySchedule nanySchedule)
        {
            if (id != nanySchedule.Schedule_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nanySchedule);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NanyScheduleExists(nanySchedule.Schedule_Id))
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
            return View(nanySchedule);
        }

        // GET: NanySchedules/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nanySchedule = await _context.NanySchedule
                .FirstOrDefaultAsync(m => m.Schedule_Id == id);
            if (nanySchedule == null)
            {
                return NotFound();
            }

            return View(nanySchedule);
        }

        // POST: NanySchedules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nanySchedule = await _context.NanySchedule.FindAsync(id);
            _context.NanySchedule.Remove(nanySchedule);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NanyScheduleExists(int id)
        {
            return _context.NanySchedule.Any(e => e.Schedule_Id == id);
        }
    }
}
