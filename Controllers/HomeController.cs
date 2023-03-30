using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TheCause.Data;
using TheCause.Models;

namespace TheCause.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
       
        public async Task<IActionResult> Index()
        {

            var petitions = await _context.Petitions
                .Include(s => s.Signs)
                .OrderByDescending(p => p.CreatedAt )
                .Take(5)
                .ToListAsync();

            return View(petitions);
        }

        // GET: Petitions
        public async Task<IActionResult> Causes()
        {
            var petitions = await _context.Petitions
                .OrderByDescending(p => p.CreatedAt)
                .ToListAsync();

            return View(petitions);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Service()
        {
            return View();
        }
        public IActionResult Term()
        {
            return View();
        }
        public IActionResult Policy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public Sign Sign(int id)
        {
            var sign = _context.Signs.
                Where(s => s.PetitionId == id);

            return sign.First();
        }

    }
}
