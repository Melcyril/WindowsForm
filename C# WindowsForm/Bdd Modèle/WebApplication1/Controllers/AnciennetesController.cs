using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AnciennetesController : Controller
    {
        private baeEntities db = new baeEntities();

        // GET: Anciennetes
        public ActionResult Index()
        {
            return View(db.Anciennete.ToList());
        }

        // GET: Anciennetes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Anciennete anciennete = db.Anciennete.Find(id);
            if (anciennete == null)
            {
                return HttpNotFound();
            }
            return View(anciennete);
        }

        // GET: Anciennetes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Anciennetes/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdAnciennete,DureeExperience")] Anciennete anciennete)
        {
            if (ModelState.IsValid)
            {
                db.Anciennete.Add(anciennete);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(anciennete);
        }

        // GET: Anciennetes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Anciennete anciennete = db.Anciennete.Find(id);
            if (anciennete == null)
            {
                return HttpNotFound();
            }
            return View(anciennete);
        }

        // POST: Anciennetes/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdAnciennete,DureeExperience")] Anciennete anciennete)
        {
            if (ModelState.IsValid)
            {
                db.Entry(anciennete).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(anciennete);
        }

        // GET: Anciennetes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Anciennete anciennete = db.Anciennete.Find(id);
            if (anciennete == null)
            {
                return HttpNotFound();
            }
            return View(anciennete);
        }

        // POST: Anciennetes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Anciennete anciennete = db.Anciennete.Find(id);
            db.Anciennete.Remove(anciennete);
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
