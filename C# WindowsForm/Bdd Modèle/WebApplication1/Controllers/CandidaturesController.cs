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
    public class CandidaturesController : Controller
    {
        private baeEntities db = new baeEntities();

        // GET: Candidatures
        public ActionResult Index()
        {
            var candidature = db.Candidature.Include(c => c.Offre);
            return View(candidature.ToList());
        }

        // GET: Candidatures/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Candidature candidature = db.Candidature.Find(id);
            if (candidature == null)
            {
                return HttpNotFound();
            }
            return View(candidature);
        }

        // GET: Candidatures/Create
        public ActionResult Create()
        {
            ViewBag.IdOffre = new SelectList(db.Offre, "IdOffre", "NumeroOffre");
            return View();
        }

        // POST: Candidatures/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdCandidature,DATECandidature,IdOffre")] Candidature candidature)
        {
            if (ModelState.IsValid)
            {
                db.Candidature.Add(candidature);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdOffre = new SelectList(db.Offre, "IdOffre", "NumeroOffre", candidature.IdOffre);
            return View(candidature);
        }

        // GET: Candidatures/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Candidature candidature = db.Candidature.Find(id);
            if (candidature == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdOffre = new SelectList(db.Offre, "IdOffre", "NumeroOffre", candidature.IdOffre);
            return View(candidature);
        }

        // POST: Candidatures/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdCandidature,DATECandidature,IdOffre")] Candidature candidature)
        {
            if (ModelState.IsValid)
            {
                db.Entry(candidature).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdOffre = new SelectList(db.Offre, "IdOffre", "NumeroOffre", candidature.IdOffre);
            return View(candidature);
        }

        // GET: Candidatures/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Candidature candidature = db.Candidature.Find(id);
            if (candidature == null)
            {
                return HttpNotFound();
            }
            return View(candidature);
        }

        // POST: Candidatures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Candidature candidature = db.Candidature.Find(id);
            db.Candidature.Remove(candidature);
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
