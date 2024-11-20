using System.Collections.Generic;
using System.Diagnostics;
using BL;
using Entidades;
using Microsoft.AspNetCore.Mvc;
using PracticaUI.Models;

namespace PracticaUI.Controllers
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
            List<clsPersona> listaPersonas = new List<clsPersona>();
            try
            {
                listaPersonas = clsListadosBL.listadoCompletoPersonasBL();
            }catch (Exception ex)
            {
                throw;
            }
            
            return View(listaPersonas);
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
