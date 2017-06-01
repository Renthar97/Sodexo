using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Sodexo.Entities.Entities;
using Sodexo.Persistence;

namespace Sodexo.Controllers
{
    public class LlamadaController : Controller
    {
        private SodexoDbContext db = new SodexoDbContext();

        // GET: Llamada
        public ActionResult Index()
        {
            return View(db.Llamada.ToList());
        }

        // GET: Llamada/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Llamada llamada = db.Llamada.Find(id);
            if (llamada == null)
            {
                return HttpNotFound();
            }
            return View(llamada);
        }

        // GET: Llamada/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Llamada/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LlamadaId,NroEntrante,Duracion,TipoAtencion")] Llamada llamada)
        {
            if (ModelState.IsValid)
            {
                db.Llamada.Add(llamada);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(llamada);
        }

        // GET: Llamada/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Llamada llamada = db.Llamada.Find(id);
            if (llamada == null)
            {
                return HttpNotFound();
            }
            return View(llamada);
        }

        // POST: Llamada/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LlamadaId,NroEntrante,Duracion,TipoAtencion")] Llamada llamada)
        {
            if (ModelState.IsValid)
            {
                db.Entry(llamada).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(llamada);
        }

        // GET: Llamada/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Llamada llamada = db.Llamada.Find(id);
            if (llamada == null)
            {
                return HttpNotFound();
            }
            return View(llamada);
        }

        // POST: Llamada/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Llamada llamada = db.Llamada.Find(id);
            db.Llamada.Remove(llamada);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
