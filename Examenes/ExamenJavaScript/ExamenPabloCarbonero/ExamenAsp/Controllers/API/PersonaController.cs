using BL;
using Entidades;
using ExamenAsp.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExamenAsp.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        /// <summary>
        /// Metodo Post para obtener la lista de personas
        /// Se realiza un verbo POST ya que se le envia un objeto por parametro
        /// </summary>
        /// <param name="departamento"></param>
        /// <returns>codigo de respuesta</returns>
        // GET: api/<PersonaController>
        [HttpPost]
        public IActionResult Post(clsDepartamento departamento)
        {
            IActionResult salida;
            List<clsPersona> listado = new List<clsPersona>();
            //int idDept = clsListadosBL.getIdDepartamentoPorNombre(nombreDept);
            try
            {
                listado = clsListadosBL.listadoPersonasDepartamentoBL(departamento.Id);

                salida = Ok(listado);
            }
            catch (Exception ex)
            {
                salida = BadRequest();
            }

            return salida;
        }

        /// <summary>
        /// Metodo GET para obtener una persona por su id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>codigo de respuesta</returns>
        // GET api/<PersonaController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            IActionResult salida;
            clsPersona persona = new clsPersona();

            try
            {
                persona = clsListadosBL.getPersonaIdBL(id);
                clsPersonaNombreDept personaDept = new clsPersonaNombreDept(persona);

                salida = Ok(personaDept);
            }
            catch (Exception ex)
            {
                salida = BadRequest();
            }

            return salida;
        }
    }
}
    

