using api.Models;
using BL;
using Entidades;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api.Controllers.APi
{
    [Route("api/[controller]")]
    [ApiController]
    public class BandoController : ControllerBase
    {
        // GET: api/<BandoController>
        [HttpGet]
        public IActionResult Get()
        {
            IActionResult salida;
            List<clsBando> l = new List<clsBando>();

            try
            {
                l = clsListadosBL.listadoBandosBL();

                salida = Ok(l);
            }
            catch (Exception ex)
            {
                salida = BadRequest();
            }

            return salida;
        }

        // GET api/<BandoController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            IActionResult salida;
            clsBando b = new clsBando();

            try
            {
                b = clsListadosBL.getBando(id);

                salida = Ok(b);
            }
            catch (Exception ex)
            {
                salida = BadRequest();
            }

            return salida;
        }
    }
}
