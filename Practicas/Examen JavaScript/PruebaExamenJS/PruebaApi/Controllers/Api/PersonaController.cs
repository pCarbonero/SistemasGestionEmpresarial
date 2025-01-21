using Entidades;
using DAL;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PruebaApi.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        // GET: api/<PersonaController>
        [HttpGet]
        public IActionResult Get()
        {
            IActionResult salida;

            List<clsPersona> listaPersonas;

            try
            {
                listaPersonas = clsListadosDAL.getPersonasDAL();
                if (listaPersonas.Count() == 0)
                {
                    salida = NoContent();
                }
                else
                {
                    salida = Ok(listaPersonas);
                }
            }
            catch (Exception ex)
            {
                salida = BadRequest(ex.Message);
            }

            return salida;
        }

        // GET api/<PersonaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PersonaController>
        [HttpPost]
        public IActionResult Post([FromBody] clsPersona personaAdd)
        {
            IActionResult salida;
            bool guardado = false;
            try
            {
                clsListadosDAL.addPersona(personaAdd);
                guardado = true;
                salida = Ok(guardado);
            }
            catch (Exception ex)
            {
                salida = BadRequest();
            }

            return salida;
        }

        // PUT api/<PersonaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PersonaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
