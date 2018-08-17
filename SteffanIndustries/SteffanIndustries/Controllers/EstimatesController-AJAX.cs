using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SteffanIndustries.Models;

namespace SteffanIndustries.Controllers
{
    public class EstimatesController_AJAX : Controller
    {
        private readonly SteffanContext _context;

        public EstimatesController_AJAX(SteffanContext context)
        {
            _context = context;
        }

        // GET: Estimates
        public async Task<IActionResult> Index()
        {
            return View(await _context.Estimate.ToListAsync());
        }

        // GET: Estimates/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estimate = await _context.Estimate
                .Include(e => e.EstimateDetail)
                .AsNoTracking()
                .SingleOrDefaultAsync(m => m.EstimateID == id);
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

        // Original POST: created by MVC
        // POST: Estimates/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("EstimateID,EstimateDate,JobName,Scope,Contact")] Estimate estimate)
        //{
        //    if (ModelState.IsValid)
        //   {
        //       _context.Add(estimate);
        //       await _context.SaveChangesAsync();
        //       return RedirectToAction("Index");
        //  }
        //   return View(estimate);
        //}
        // New version of the Create POST: from 
        [HttpPost]
        public JsonResult Create([FromBody] Estimate estimate)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    foreach (EstimateDetail ed in estimate.EstimateDetail)
                        _context.EstimateDetail.Add(ed);

                    _context.Estimate.Add(estimate);

                    _context.SaveChanges();

                    return Json(new { success = true });
                }
                else
                {
                    return Json(new { success = false });
                }
            }
            catch (Exception)
            {
                return Json(new { success = false });
            }
        }

        // GET: Estimates/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estimate = await _context.Estimate
                .Include(e => e.EstimateDetail)
                .SingleOrDefaultAsync(m => m.EstimateID == id);

            if (estimate == null)
            {
                return NotFound();
            }
            return View(estimate);
        }

        // POST: Estimates/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EstimateID,EstimateDate,JobName,Scope,Contact")] Estimate estimate)
        {
            if (id != estimate.EstimateID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estimate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstimateExists(estimate.EstimateID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(estimate);
        }

        // GET: Estimates/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estimate = await _context.Estimate
                .SingleOrDefaultAsync(m => m.EstimateID == id);
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
            var estimate = await _context.Estimate.SingleOrDefaultAsync(m => m.EstimateID == id);
            _context.Estimate.Remove(estimate);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        /// <summary>Action that updates data
        /// </summary>
        /// <param name="id">Id of the record</param>
        /// <param name="value">Value that should be set</param>
        /// <param name="rowId">Id of the row</param>
        /// <param name="columnPosition">Position of the
        ///           column(hidden columns are not counted)</param>
        /// <param name="columnId">Position of the column(hidden columns are counted)</param>
        /// <param name="columnName">Name of the column</param>
        /// <returns>value if update suceed - any other value
        ///        will be considered as an error message on the client-side</returns>
        public string UpdateData(int id, string value, int? rowId, int? columnPosition, int? columnId, string columnName)
        {

            // Instead of updating each row / value individually, it will be updated when the
            // estimate is updated.
            // Just return the value sent
            return value;

            // Example if we want to update the row immediately
            //            if (id != estimate.EstimateID)
            //            {
            //                return NotFound();
            //            }
            //
            //if (columnPosition == 0 && companies.Any(
            //                      c => c.Name.ToLower().Equals(value.ToLower())))
            //                return "Company with a name '" + value + "' already exists";
            //            var company = companies.FirstOrDefault(c => c.ID == id);
            //            if (company == null)
            //            {
            //                return "Company with an id = " + id + " does not exists";
            //            }
            //            switch (columnPosition)
            //            {
            //                case 0:
            //                    company.Name = value;
            //                    break;
            //                case 1:
            //                    company.Address = value;
            //                    break;
            //                case 2:
            //                    company.Town = value;
            //                    break;
            //                default:
            //                    break;
            //            }
            //            return value;
        }

    
        private bool EstimateExists(int id)
        {
            return _context.Estimate.Any(e => e.EstimateID == id);
        }
    }
}
