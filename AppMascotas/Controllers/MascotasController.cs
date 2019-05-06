using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppMascotas.Models;
using System.Web.Mvc;
using System.Net;
using System.Data.Entity;

namespace AppMascotas.Controllers
{
    public class MascotasController : Controller
    {
        private readonly CrudContext _context = new CrudContext();
        // GET: Mascotas
        public ActionResult Index()
        {
            var mascotas = _context.Mascotas.ToList();
            return View(mascotas);
        }
        // Get  
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Mascota mascota)
        {
            if (ModelState.IsValid)
            {
                _context.Mascotas.Add(mascota);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mascota);
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var employee = _context.Mascotas.SingleOrDefault(e => e.MascotaId == id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }
        [HttpPost]
        public ActionResult Edit(Mascota mascota)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(mascota).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mascota);
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var mascota = _context.Mascotas.SingleOrDefault(e => e.MascotaId == id);
            if (mascota == null)
            {
                return HttpNotFound();
            }
            return View(mascota);
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var mascota = _context.Mascotas.SingleOrDefault(e => e.MascotaId == id);
            if (mascota == null)
            {
                return HttpNotFound();
            }
            return View(mascota);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var mascota = _context.Mascotas.SingleOrDefault(x => x.MascotaId == id);
            _context.Mascotas.Remove(mascota ?? throw new InvalidOperationException());
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}