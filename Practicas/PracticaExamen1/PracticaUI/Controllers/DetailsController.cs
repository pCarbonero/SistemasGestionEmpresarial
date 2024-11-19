using BL;
using Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PracticaUI.Controllers
{
    public class DetailsController : Controller
    {
        // GET: EditController
        public ActionResult Index()
        {
            return View();
        }

        // GET: EditController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EditController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EditController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EditController/Edit/5
        public ActionResult Edit(int id)
        {
            ClsPersona persona = ClsListadosBL.getPersonaID(id);
            return View(persona);
        }

        // POST: EditController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection, ClsPersona persona)
        {
            try
            {
                ClsListadosBL.editarPersonaIdBL(persona);
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: EditController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EditController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
