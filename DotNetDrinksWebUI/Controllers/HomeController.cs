using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DotNetDrinks.Data;
using DotNetDrinks.Models;
using System.Diagnostics;
using System.Linq;
using DotNetDrinksWebUI.Data;
using DotNetDrinksWebUI.Models;

namespace DotNetDrinks.Controllers
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

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // ✅ Step 2 - Support page
        public IActionResult Support()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
