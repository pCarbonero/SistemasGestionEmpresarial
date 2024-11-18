using DAL;
using Ejercicio01.Models;
using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;
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
            return View();
        }

        [HttpPost]
        public ActionResult ConectarBD()
        {
            clsMyConnection connection = new clsMyConnection();
            SqlConnection c = new SqlConnection();
            try
            {
                c = connection.getConnection();
                ViewBag.estado = c.ToString();
            }
            catch (Exception ex)
            {
                ViewBag.estado = ex.ToString();
            }
            finally
            {
                connection.closeConnection(ref c);
            }
                 
            return View("Index");
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
