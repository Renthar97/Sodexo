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
    public class ReposicionBloqueoController : Controller
    {
        private SodexoDbContext db = new SodexoDbContext();

        // GET: ReposicionBloqueo
        public ActionResult Index()
        {
            return View(db.ReposicionBloqueo.ToList());
        }

        // GET: ReposicionBloqueo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReposicionBloqueo reposicionBloqueo = db.ReposicionBloqueo.Find(id);
            if (reposicionBloqueo == null)
            {
                return HttpNotFound();
            }
            return View(reposicionBloqueo);
        }

        // GET: ReposicionBloqueo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReposicionBloqueo/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ReposicionBloqueoId,Bloqueo,CostoReposicion,CostoEnvio")] ReposicionBloqueo reposicionBloqueo)
        {
            if (ModelState.IsValid)
            {
                db.ReposicionBloqueo.Add(reposicionBloqueo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(reposicionBloqueo);
        }

        // GET: ReposicionBloqueo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReposicionBloqueo reposicionBloqueo = db.ReposicionBloqueo.Find(id);
            if (reposicionBloqueo == null)
            {
                return HttpNotFound();
            }
            return View(reposicionBloqueo);
        }

        // POST: ReposicionBloqueo/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ReposicionBloqueoId,Bloqueo,CostoReposicion,CostoEnvio")] ReposicionBloqueo reposicionBloqueo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reposicionBloqueo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(reposicionBloqueo);
        }

        // GET: ReposicionBloqueo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReposicionBloqueo reposicionBloqueo = db.ReposicionBloqueo.Find(id);
            if (reposicionBloqueo == null)
            {
                return HttpNotFound();
            }
            return View(reposicionBloqueo);
        }

        // POST: ReposicionBloqueo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ReposicionBloqueo reposicionBloqueo = db.ReposicionBloqueo.Find(id);
            db.ReposicionBloqueo.Remove(reposicionBloqueo);
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
