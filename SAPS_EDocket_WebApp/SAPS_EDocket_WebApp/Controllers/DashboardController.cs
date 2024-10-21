using Microsoft.AspNetCore.Mvc;

namespace SAPS_EDocket_WebApp.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
