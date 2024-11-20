using BL;
using Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracticaUI.Models.ViewModels;

namespace PracticaUI.Controllers
{
    public class PersonaController : Controller
    {
        // GET: EditController
        public ActionResult Index()
        {
            PersonaListaPersonasVM personaListaPersonasVM = new PersonaListaPersonasVM();
            return View(personaListaPersonasVM);
        }

        [HttpPost]
        public ActionResult Index(int id)
        {
            PersonaListaPersonasVM personaListaPersonasVM = new PersonaListaPersonasVM();
            personaListaPersonasVM.Persona = clsListadosBL.getPersonaID(id);
            return View(personaListaPersonasVM);
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
            clsPersona persona = clsListadosBL.getPersonaID(id);
            return View(persona);
        }

        // POST: EditController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection, clsPersona persona)
        {
            try
            {
                clsListadosBL.editarPersonaIdBL(persona);
                return RedirectToAction("Index");
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
