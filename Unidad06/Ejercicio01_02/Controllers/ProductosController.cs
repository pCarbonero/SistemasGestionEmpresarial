using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ejercicio01_02.Controllers
{
    public class ProductosController : Controller
    {
        public ActionResult ListadoProductos()
        {
            return View();
        }
    }
}
