﻿using BL;
using Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ejercicio02ListadoBDASP.Controllers
{
    public class DetailsController : Controller
    {
        // GET: DetailsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DetailsController/Details/5
        public ActionResult Details(int id)
        {
            clsPersona persona = clsListadosBL.getPersonaIdBL(id);
            return View(persona);
        }

        // GET: DetailsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DetailsController/Create
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

        // GET: DetailsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DetailsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: DetailsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DetailsController/Delete/5
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
