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
    public class AccesController : Controller
    {
        private baeEntities db = new baeEntities();

        // GET: Acces
        public ActionResult Index()
        {
            return View(db.Acces.ToList());
        }

        // GET: Acces/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Acces acces = db.Acces.Find(id);
            if (acces == null)
            {
                return HttpNotFound();
            }
            return View(acces);
        }

        // GET: Acces/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Acces/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdAcces,Statut,Date")] Acces acces)
        {
            if (ModelState.IsValid)
            {
                db.Acces.Add(acces);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(acces);
        }

        // GET: Acces/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Acces acces = db.Acces.Find(id);
            if (acces == null)
            {
                return HttpNotFound();
            }
            return View(acces);
        }

        // POST: Acces/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdAcces,Statut,Date")] Acces acces)
        {
            if (ModelState.IsValid)
            {
                db.Entry(acces).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(acces);
        }

        // GET: Acces/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Acces acces = db.Acces.Find(id);
            if (acces == null)
            {
                return HttpNotFound();
            }
            return View(acces);
        }

        // POST: Acces/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Acces acces = db.Acces.Find(id);
            db.Acces.Remove(acces);
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
