using jQuery_Demo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace jQuery_Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult jQuerySelectors()
        {
            return View();
        }

        public IActionResult jQueryMouse_Keyboard()
        {
            return View();
        }
        public IActionResult jQueryFormEvents_CRUD()
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
