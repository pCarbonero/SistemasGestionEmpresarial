using BL;
using ListadoPersonasASP.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ListadoPersonasASP.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View(ClsListadosBl.listadoPersonasBl());
        }    
    }
}
