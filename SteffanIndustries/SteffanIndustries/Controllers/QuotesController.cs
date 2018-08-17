using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SteffanIndustries.Models.ViewModels;
using SteffanIndustries.Models;

namespace SteffanIndustries.Controllers
{
    public class QuotesController : Controller
    {
        private readonly SteffanContext _context;

        public QuotesController(SteffanContext context)
        {
            _context = context;    
        }

        // GET: Quotes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Quote.ToListAsync());
        }

        // GET: Quotes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
           
            var quote = await _context.Quote
                .Include(c => c.QuoteNote)
                .AsNoTracking()
                .SingleOrDefaultAsync(m => m.QuoteID == id);

            if (quote == null)
            {
                return NotFound();
            }

            return View(quote);
        }

        // GET: Quotes/Create
        public IActionResult Create()
        {
            var quote = new Quote();
            quote.QuoteNote = new List<QuoteNote>();
            return View(quote);
        }

        // POST: Quotes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("QuoteID,QuoteDate,CompanyName,AddressLine1,AddressLine2,City,State,Zip,Contact,ContactEmail,ContactPhone,JobName,JobScope,JobCost")] Quote quote, string[] quotenotes)
        {
            if (quotenotes != null)
            {
                quote.QuoteNote = new List<QuoteNote>();
                foreach (var note in quotenotes)
                {
                    var noteToAdd = new QuoteNote { QuoteID = quote.QuoteID };
                    quote.QuoteNote.Add(noteToAdd);
                }
            }

            if (ModelState.IsValid)
            {
                _context.Add(quote);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(quote);
        }

        // GET: Quotes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            var quote = await _context.Quote
                .Include(c => c.QuoteNote)
                .AsNoTracking()
                .SingleOrDefaultAsync(m => m.QuoteID == id);

            if (quote == null)
            {
                return NotFound();
            }
            return View(quote);
        }

        // POST: Quotes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("QuoteID,QuoteDate,CompanyName,AddressLine1,AddressLine2,City,State,Zip,Contact,ContactEmail,ContactPhone,JobName,JobScope,JobCost")] Quote quote, string[] quotenotes)
        {
            if (id != quote.QuoteID)
            {
                return NotFound();
            }
            var quoteToUpdate = await _context.Quote
                .Include(i => i.QuoteNote)
                .SingleOrDefaultAsync(s => s.QuoteID == id);

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(quoteToUpdate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuoteExists(quote.QuoteID))
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
            return View(quote);
        }

        // GET: Quotes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quote = await _context.Quote
                .SingleOrDefaultAsync(m => m.QuoteID == id);
            if (quote == null)
            {
                return NotFound();
            }

            return View(quote);
        }

        // POST: Quotes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var quote = await _context.Quote.SingleOrDefaultAsync(m => m.QuoteID == id);
            _context.Quote.Remove(quote);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool QuoteExists(int id)
        {
            return _context.Quote.Any(e => e.QuoteID == id);
        }
        [AjaxOnly]
        [ResponseCache(NoStore = true, Duration = 0)]
        public IActionResult NewItem()
        {
            return PartialView("_QuoteNotePartial", new QuoteNote());
        }
    }
}
