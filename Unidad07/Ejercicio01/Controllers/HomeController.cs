using Ejercicio01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ejercicio01.Controllers
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
            if (DateTime.Now.Hour >= 5 && DateTime.Now.Hour < 12)
            {
                ViewBag.Mensaje = "Buenos días";
            }
            else if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 20)
            {
                ViewBag.Mensaje = "Buenas tardes";
            }
            else if (DateTime.Now.Hour >= 20 && DateTime.Now.Hour < 5)
            {
                ViewBag.Mensaje = "Buenas noches";
            }
            return View();
        }

        public IActionResult Privacy()
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
