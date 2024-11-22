using System.Diagnostics;
using BL;
using Entidades;
using ExamenUI.Models;
using ExamenUI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ExamenUI.Controllers
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
            ListaMisionesCandidatosVM vm;
            try
            {
                vm = new ListaMisionesCandidatosVM();
            }catch (Exception ex)
            {
                return View("Error");
            }
            return View(vm);
        }

        /// <summary>
        /// Cuando se pulsa en el boton mostrar candidatos se hace el metodo post el cual muestra la lista de candidatos
        /// </summary>
        /// <param name="idMision"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Index(int idMision)
        {
            ListaMisionesCandidatosVM vm;
            try
            {
                vm = new ListaMisionesCandidatosVM(idMision);
            }
            catch (Exception ex)
            {
                return View("Error");
            }
            return View(vm);
        }

        /// <summary>
        /// ActioResult para la vista de detalles.
        /// Se crea un objeto de clsCandidato y se pasan sus propiedades por parametros para un model clsCandidatoConEdad para crearlo 
        /// pasarlo a la visa
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Details(int id)
        {
            try
            {
                clsCandidato candidato = clsListadosBL.getCandidatoPorIdBL(id);

                clsCandidatoConEdad candidatoConEdad =
                    new clsCandidatoConEdad(candidato.Id, candidato.Nombre, candidato.Apellidos, candidato.Direccion,
                                            candidato.Nacionalidad, candidato.Telefono, candidato.FechaNacimiento, candidato.PrecioMedio);

                return View(candidatoConEdad);
            }catch (Exception ex)
            {
                return View("Error");
            }

        }
    }
}
