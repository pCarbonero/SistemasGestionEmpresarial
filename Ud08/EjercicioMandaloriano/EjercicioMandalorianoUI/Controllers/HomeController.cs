using BL;
using EjercicioMandalorianoUI.Models;
using EjercicioMandalorianoUI.Models.ViewModels;
using Entidades;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EjercicioMandalorianoUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            try
            {
                VerMisionesVM vm = new VerMisionesVM();
                vm.listadoMisiones = ClsListadosBL.listadoMisionesBL();

                return View(vm);
            }
            catch (HourException ex)
            {
                return View("TardeView");
            }           
        }

        [HttpPost]
        public IActionResult Index(int idMision)
        {
            VerMisionesVM vm = new VerMisionesVM();
            vm.listadoMisiones = ClsListadosBL.listadoMisionesBL();
            vm.misionSeleccionada = ClsListadosBL.misionPorIdBL(idMision);


            return View(vm);
        }
    }
}
