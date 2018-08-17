using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Steffan.Data;
using SteffanIndustries.Models;

namespace Steffan.Controllers
{
    public class EstimatesController : Controller
    {
        private readonly SteffanContext _context;

        public EstimatesController(SteffanContext context)
        {
            _context = context;
        }

        // GET: Estimates
        public async Task<IActionResult> Index()
        {
            return View(await _context.Estimates.ToListAsync());
        }

        // GET: Estimates/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estimate = await _context.Estimates
                .Include(e => e.EstimateDetails)
                .AsNoTracking()
                .SingleOrDefaultAsync(m => m.ID == id);

            if (estimate == null)
            {
                return NotFound();
            }

            return View(estimate);
        }

        // GET: Estimates/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Estimates/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,EstimateDate,JobName,Scope,Contact,ContactPhone")] Estimate estimate)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estimate);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(estimate);
        }

        // GET: Estimates/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estimate = await _context.Estimates.SingleOrDefaultAsync(m => m.ID == id);
            if (estimate == null)
            {
                return NotFound();
            }
            return View(estimate);
        }

        // POST: Estimates/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estimateToUpdate = await _context.Estimates.SingleOrDefaultAsync(s => s.ID == id);

            if (await TryUpdateModelAsync<Estimate>(
                estimateToUpdate,
                "",
                s => s.EstimateDate, s => s.JobName, s => s.Scope, s => s.Contact, s => s.ContactPhone ))
            {
                try
                {
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException /* ex */)
                {
                    //Log the error (uncomment ex variable name and write a log.)
                    ModelState.AddModelError("", "Unable to save changes. " +
                        "Try again, and if the problem persists, " +
                        "see your system administrator.");
                }
            }
            return View(estimateToUpdate);
        }

        // GET: Estimates/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estimate = await _context.Estimates
                .SingleOrDefaultAsync(m => m.ID == id);
            if (estimate == null)
            {
                return NotFound();
            }

            return View(estimate);
        }

        // POST: Estimates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var estimate = await _context.Estimates.SingleOrDefaultAsync(m => m.ID == id);
            _context.Estimates.Remove(estimate);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EstimateExists(int id)
        {
            return _context.Estimates.Any(e => e.ID == id);
        }
    }
}
