using BL;
using Entidades;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExamenAsp.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentoController : ControllerBase
    {
        /// <summary>
        /// Metodo GET para obtener todos los departamentos
        /// </summary>
        /// <returns></returns>
        // GET: api/<DepartamentoController>
        [HttpGet]
        public IActionResult Get()
        {
            IActionResult salida;
            List<clsDepartamento> listado = new List<clsDepartamento>();

            try
            {
                listado = clsListadosBL.getListaDepartamentosBL();

                salida = Ok(listado);
            }
            catch (Exception ex)
            {
                salida = BadRequest();
            }

            return salida;
        }
    }
}
