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
            Random random = new Random();   
            List<ClsPersona> list = ClsListado.listadoPersonas();
            int randomNumber = random.Next(0, list.Count);


            ClsPersona persona = list[randomNumber];
            
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
