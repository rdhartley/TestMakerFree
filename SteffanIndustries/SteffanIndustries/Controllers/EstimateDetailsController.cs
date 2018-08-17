using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SteffanIndustries.Models;
using Microsoft.EntityFrameworkCore;

namespace SteffanIndustries.Controllers
{
    public class EstimateDetailsController : Controller
    {
        private readonly SteffanContext _context;

        public EstimateDetailsController(SteffanContext context)
        {
            _context = context;
        }

        // GET: EstimateDeatils
        public async Task<IActionResult> Index()
        {
            return View(await _context.EstimateDetail.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }


    }
}
