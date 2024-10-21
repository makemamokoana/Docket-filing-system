using Microsoft.AspNetCore.Mvc;
using SAPS_EDocket_WebApp.Models;
using System.Diagnostics;

namespace SAPS_EDocket_WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Authenticate(string uniqueId, string password)
        {
            // Here you would implement authentication logic, checking against a database or API
            if (uniqueId == "admin" && password == "password123") // Placeholder logic
            {
                return RedirectToAction("Index", "Dashboard"); // Redirect to Dashboard upon success
            }

            // On failure, return to login page with error message
            ViewBag.Error = "Invalid credentials";
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
