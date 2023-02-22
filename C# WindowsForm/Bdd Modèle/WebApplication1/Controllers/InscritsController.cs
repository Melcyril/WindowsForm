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
    public class InscritsController : Controller
    {
        private baeEntities db = new baeEntities();

        // GET: Inscrits
        public ActionResult Index()
        {
            var inscrit = db.Inscrit.Include(i => i.Acces).Include(i => i.Adresse).Include(i => i.Candidature).Include(i => i.Maintenance);
            return View(inscrit.ToList());
        }

        // GET: Inscrits/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inscrit inscrit = db.Inscrit.Find(id);
            if (inscrit == null)
            {
                return HttpNotFound();
            }
            return View(inscrit);
        }

        // GET: Inscrits/Create
        public ActionResult Create()
        {
            ViewBag.IdAcces = new SelectList(db.Acces, "IdAcces", "Statut");
            ViewBag.IdAdresse = new SelectList(db.Adresse, "IdAdresse", "Rue");
            ViewBag.IdCandidature = new SelectList(db.Candidature, "IdCandidature", "IdCandidature");
            ViewBag.IdMaintenance = new SelectList(db.Maintenance, "IdMaintenance", "MessageMaintenance");
            return View();
        }

        // POST: Inscrits/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdInscrit,Nom,Prenom,Email,Siret,IdAcces,IdAdresse,IdMaintenance,IdCandidature")] Inscrit inscrit)
        {
            if (ModelState.IsValid)
            {
                db.Inscrit.Add(inscrit);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdAcces = new SelectList(db.Acces, "IdAcces", "Statut", inscrit.IdAcces);
            ViewBag.IdAdresse = new SelectList(db.Adresse, "IdAdresse", "Rue", inscrit.IdAdresse);
            ViewBag.IdCandidature = new SelectList(db.Candidature, "IdCandidature", "IdCandidature", inscrit.IdCandidature);
            ViewBag.IdMaintenance = new SelectList(db.Maintenance, "IdMaintenance", "MessageMaintenance", inscrit.IdMaintenance);
            return View(inscrit);
        }

        // GET: Inscrits/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inscrit inscrit = db.Inscrit.Find(id);
            if (inscrit == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdAcces = new SelectList(db.Acces, "IdAcces", "Statut", inscrit.IdAcces);
            ViewBag.IdAdresse = new SelectList(db.Adresse, "IdAdresse", "Rue", inscrit.IdAdresse);
            ViewBag.IdCandidature = new SelectList(db.Candidature, "IdCandidature", "IdCandidature", inscrit.IdCandidature);
            ViewBag.IdMaintenance = new SelectList(db.Maintenance, "IdMaintenance", "MessageMaintenance", inscrit.IdMaintenance);
            return View(inscrit);
        }

        // POST: Inscrits/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdInscrit,Nom,Prenom,Email,Siret,IdAcces,IdAdresse,IdMaintenance,IdCandidature")] Inscrit inscrit)
        {
            if (ModelState.IsValid)
            {
                db.Entry(inscrit).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdAcces = new SelectList(db.Acces, "IdAcces", "Statut", inscrit.IdAcces);
            ViewBag.IdAdresse = new SelectList(db.Adresse, "IdAdresse", "Rue", inscrit.IdAdresse);
            ViewBag.IdCandidature = new SelectList(db.Candidature, "IdCandidature", "IdCandidature", inscrit.IdCandidature);
            ViewBag.IdMaintenance = new SelectList(db.Maintenance, "IdMaintenance", "MessageMaintenance", inscrit.IdMaintenance);
            return View(inscrit);
        }

        // GET: Inscrits/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inscrit inscrit = db.Inscrit.Find(id);
            if (inscrit == null)
            {
                return HttpNotFound();
            }
            return View(inscrit);
        }

        // POST: Inscrits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Inscrit inscrit = db.Inscrit.Find(id);
            db.Inscrit.Remove(inscrit);
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
