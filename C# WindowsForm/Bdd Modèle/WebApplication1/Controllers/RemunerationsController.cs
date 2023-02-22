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
    public class RemunerationsController : Controller
    {
        private baeEntities db = new baeEntities();

        // GET: Remunerations
        public ActionResult Index()
        {
            return View(db.Remuneration.ToList());
        }

        // GET: Remunerations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Remuneration remuneration = db.Remuneration.Find(id);
            if (remuneration == null)
            {
                return HttpNotFound();
            }
            return View(remuneration);
        }

        // GET: Remunerations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Remunerations/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdRemuneration,SalaireAnnuelle")] Remuneration remuneration)
        {
            if (ModelState.IsValid)
            {
                db.Remuneration.Add(remuneration);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(remuneration);
        }

        // GET: Remunerations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Remuneration remuneration = db.Remuneration.Find(id);
            if (remuneration == null)
            {
                return HttpNotFound();
            }
            return View(remuneration);
        }

        // POST: Remunerations/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdRemuneration,SalaireAnnuelle")] Remuneration remuneration)
        {
            if (ModelState.IsValid)
            {
                db.Entry(remuneration).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(remuneration);
        }

        // GET: Remunerations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Remuneration remuneration = db.Remuneration.Find(id);
            if (remuneration == null)
            {
                return HttpNotFound();
            }
            return View(remuneration);
        }

        // POST: Remunerations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Remuneration remuneration = db.Remuneration.Find(id);
            db.Remuneration.Remove(remuneration);
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
