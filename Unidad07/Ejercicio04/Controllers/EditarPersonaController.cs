using Ejercicio04.Models.DAL;
using Ejercicio04.Models.Entidades;
using Ejercicio04.Models.VM;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Ejercicio04.Controllers
{
    public class EditarPersonaController : Controller
    {
        public IActionResult EditarPersonaV()
        {
           /* List<ClsPersona> list = ClsListado.listadoPersonas();
            int index = random.Next(list.Count);*/

            ClsPersona persona = new ClsPersona("Pablo", "Carbonero", 21, 1);
            
            ClsEditarPersona ep = new ClsEditarPersona
            {
                Nombre = persona.Nombre,
                Apellidos = persona.Apellidos,
                Edad = persona.Edad,
                Departamento = persona.Departamento,
            };

           
            return View(ep);
        }
    }
}
