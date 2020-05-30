using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PetStore.MVC.Data;
using PetStore.MVC.Models;

namespace PetStore.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PetStoreDbContext _context;

        public HomeController(ILogger<HomeController> logger, PetStoreDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Owners.Include(o => o.Pets).ToListAsync());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
