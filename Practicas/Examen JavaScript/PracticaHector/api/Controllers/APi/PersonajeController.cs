using api.Models;
using BL;
using DAL;
using Entidades;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api.Controllers.APi
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonajeController : ControllerBase
    {
        // GET: api/<PersonajeController>
        [HttpGet]
        public IActionResult Get()
        {
            IActionResult salida;
            List<clsPersonaEdadBando> listado = new List<clsPersonaEdadBando>();
            List<clsPersonaje> l = new List<clsPersonaje>();

            try
            {
                l = clsListadosBL.listadoPersonajesBL();

                foreach (clsPersonaje p in l)
                {
                    listado.Add(new clsPersonaEdadBando(p));
                }

                salida = Ok(listado);
            }
            catch (Exception ex)
            {
                salida = BadRequest();
            }

            return salida;
        }

        // GET api/<PersonajeController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            IActionResult salida;
            clsPersonaEdadBando personaje = new clsPersonaEdadBando();

            try
            {
                personaje = new clsPersonaEdadBando(clsListadosBL.getPersonajeBL(id));
                salida = Ok(personaje);
            }
            catch (Exception ex)
            {
                salida = BadRequest();
            }

            return salida;
        }

        // POST api/<PersonajeController>
        [HttpPost]
        public IActionResult Post([FromBody] clsPersonaje p)
        {
            IActionResult salida;
            bool added;

            try
            {
                added = clsListadosDAL.addPersonaje(p);
                salida = Ok();
            }
            catch (Exception ex)
            {
                salida = BadRequest();
            }

            return salida;
        }

        // PUT api/<PersonajeController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, clsPersonaje p)
        {
            IActionResult salida;
            bool added;

            try
            {
                added = clsListadosDAL.updatePersonaje(id, p);
                salida = Ok();
            }
            catch (Exception ex)
            {
                salida = BadRequest();
            }

            return salida;
        }

        // DELETE api/<PersonajeController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            IActionResult salida;
            bool deleted;

            try
            {
                deleted = clsListadosDAL.deletePersonaje(id);
                salida = Ok();
            }
            catch (Exception ex)
            {
                salida = BadRequest();
            }

            return salida;
        }
    }
}
