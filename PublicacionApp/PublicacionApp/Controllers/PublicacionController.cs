using PublicacionApp.Context;
using PublicacionApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace PublicacionApp.Controllers
{
    public class PublicacionController : Controller
    {
        private PublicacionContext db = new PublicacionContext();

        // GET: Publicacion
        public ActionResult Index()
        {
            return View(db.Publicaciones.ToList());
        }

        // GET: Publicacion/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Publicacion publicacion = db.Publicaciones.Find(id);
            if (publicacion == null)
                return HttpNotFound();
            return View(publicacion);
        }

        // GET: Publicacion/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Publicacion/Create
        [HttpPost]
        public ActionResult Create(Publicacion publicacion)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    db.Publicaciones.Add(publicacion);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(publicacion);
            }
            catch
            {
                return View();
            }
        }

        // GET: Publicacion/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Publicacion publicacion = db.Publicaciones.Find(id);
            if (publicacion == null)
                return HttpNotFound();
            return View(publicacion);
        }

        // POST: Publicacion/Edit/5
        [HttpPost]
        public ActionResult Edit(Publicacion publicacion)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    db.Entry(publicacion).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(publicacion);
            }
            catch
            {
                return View();
            }
        }

        // GET: Publicacion/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Publicacion publicacion = db.Publicaciones.Find(id);
            if (publicacion == null)
                return HttpNotFound();
            return View(publicacion);
        }

        // POST: Publicacion/Delete/5
        [HttpPost]
        public ActionResult Delete(int? id, Publicacion pub)
        {
            try
            {
                Publicacion publicacion = new Publicacion();
                // TODO: Add delete logic here
                if (ModelState.IsValid)
                {
                    if (id == null)
                        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                    publicacion = db.Publicaciones.Find(id);
                    if (publicacion == null)
                        return HttpNotFound();
                    db.Publicaciones.Remove(publicacion);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(publicacion);
            }
            catch
            {
                return View();
            }
        }
    }
}
