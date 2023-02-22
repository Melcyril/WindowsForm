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
    public class MetiersController : Controller
    {
        private baeEntities db = new baeEntities();

        // GET: Metiers
        public ActionResult Index()
        {
            return View(db.Metier.ToList());
        }

        // GET: Metiers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Metier metier = db.Metier.Find(id);
            if (metier == null)
            {
                return HttpNotFound();
            }
            return View(metier);
        }

        // GET: Metiers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Metiers/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdMetier,CategorieMetier,NomMetier")] Metier metier)
        {
            if (ModelState.IsValid)
            {
                db.Metier.Add(metier);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(metier);
        }

        // GET: Metiers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Metier metier = db.Metier.Find(id);
            if (metier == null)
            {
                return HttpNotFound();
            }
            return View(metier);
        }

        // POST: Metiers/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdMetier,CategorieMetier,NomMetier")] Metier metier)
        {
            if (ModelState.IsValid)
            {
                db.Entry(metier).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(metier);
        }

        // GET: Metiers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Metier metier = db.Metier.Find(id);
            if (metier == null)
            {
                return HttpNotFound();
            }
            return View(metier);
        }

        // POST: Metiers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Metier metier = db.Metier.Find(id);
            db.Metier.Remove(metier);
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
