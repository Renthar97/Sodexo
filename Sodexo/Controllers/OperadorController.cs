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
    public class OperadorController : Controller
    {
        private SodexoDbContext db = new SodexoDbContext();

        // GET: Operador
        public ActionResult Index()
        {
            return View(db.Operador.ToList());
        }

        // GET: Operador/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Operador operador = db.Operador.Find(id);
            if (operador == null)
            {
                return HttpNotFound();
            }
            return View(operador);
        }

        // GET: Operador/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Operador/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OperadorId,Tipo_Operador")] Operador operador)
        {
            if (ModelState.IsValid)
            {
                db.Operador.Add(operador);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(operador);
        }

        // GET: Operador/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Operador operador = db.Operador.Find(id);
            if (operador == null)
            {
                return HttpNotFound();
            }
            return View(operador);
        }

        // POST: Operador/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OperadorId,Tipo_Operador")] Operador operador)
        {
            if (ModelState.IsValid)
            {
                db.Entry(operador).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(operador);
        }

        // GET: Operador/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Operador operador = db.Operador.Find(id);
            if (operador == null)
            {
                return HttpNotFound();
            }
            return View(operador);
        }

        // POST: Operador/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Operador operador = db.Operador.Find(id);
            db.Operador.Remove(operador);
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
