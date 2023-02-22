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
    public class OffresController : Controller
    {
        private baeEntities db = new baeEntities();

        // GET: Offres
        public ActionResult Index()
        {
            var offre = db.Offre.Include(o => o.Anciennete).Include(o => o.Contrat).Include(o => o.Metier).Include(o => o.Region).Include(o => o.Remuneration);
            return View(offre.ToList());
        }

        // GET: Offres/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Offre offre = db.Offre.Find(id);
            if (offre == null)
            {
                return HttpNotFound();
            }
            return View(offre);
        }

        // GET: Offres/Create
        public ActionResult Create()
        {
            ViewBag.IdAnciennete = new SelectList(db.Anciennete, "IdAnciennete", "DureeExperience");
            ViewBag.IdContrat = new SelectList(db.Contrat, "IdContrat", "TypeDeContrat");
            ViewBag.IdMetier = new SelectList(db.Metier, "IdMetier", "CategorieMetier");
            ViewBag.IdRegion = new SelectList(db.Region, "IdRegion", "ListeRegion");
            ViewBag.IdRemuneration = new SelectList(db.Remuneration, "IdRemuneration", "IdRemuneration");
            return View();
        }

        // POST: Offres/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdOffre,NumeroOffre,Date,TitreOffre,DescriptionOffre,IdRegion,IdMetier,IdRemuneration,IdAnciennete,IdContrat")] Offre offre)
        {
            if (ModelState.IsValid)
            {
                db.Offre.Add(offre);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdAnciennete = new SelectList(db.Anciennete, "IdAnciennete", "DureeExperience", offre.IdAnciennete);
            ViewBag.IdContrat = new SelectList(db.Contrat, "IdContrat", "TypeDeContrat", offre.IdContrat);
            ViewBag.IdMetier = new SelectList(db.Metier, "IdMetier", "CategorieMetier", offre.IdMetier);
            ViewBag.IdRegion = new SelectList(db.Region, "IdRegion", "ListeRegion", offre.IdRegion);
            ViewBag.IdRemuneration = new SelectList(db.Remuneration, "IdRemuneration", "IdRemuneration", offre.IdRemuneration);
            return View(offre);
        }

        // GET: Offres/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Offre offre = db.Offre.Find(id);
            if (offre == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdAnciennete = new SelectList(db.Anciennete, "IdAnciennete", "DureeExperience", offre.IdAnciennete);
            ViewBag.IdContrat = new SelectList(db.Contrat, "IdContrat", "TypeDeContrat", offre.IdContrat);
            ViewBag.IdMetier = new SelectList(db.Metier, "IdMetier", "CategorieMetier", offre.IdMetier);
            ViewBag.IdRegion = new SelectList(db.Region, "IdRegion", "ListeRegion", offre.IdRegion);
            ViewBag.IdRemuneration = new SelectList(db.Remuneration, "IdRemuneration", "IdRemuneration", offre.IdRemuneration);
            return View(offre);
        }

        // POST: Offres/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdOffre,NumeroOffre,Date,TitreOffre,DescriptionOffre,IdRegion,IdMetier,IdRemuneration,IdAnciennete,IdContrat")] Offre offre)
        {
            if (ModelState.IsValid)
            {
                db.Entry(offre).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdAnciennete = new SelectList(db.Anciennete, "IdAnciennete", "DureeExperience", offre.IdAnciennete);
            ViewBag.IdContrat = new SelectList(db.Contrat, "IdContrat", "TypeDeContrat", offre.IdContrat);
            ViewBag.IdMetier = new SelectList(db.Metier, "IdMetier", "CategorieMetier", offre.IdMetier);
            ViewBag.IdRegion = new SelectList(db.Region, "IdRegion", "ListeRegion", offre.IdRegion);
            ViewBag.IdRemuneration = new SelectList(db.Remuneration, "IdRemuneration", "IdRemuneration", offre.IdRemuneration);
            return View(offre);
        }

        // GET: Offres/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Offre offre = db.Offre.Find(id);
            if (offre == null)
            {
                return HttpNotFound();
            }
            return View(offre);
        }

        // POST: Offres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Offre offre = db.Offre.Find(id);
            db.Offre.Remove(offre);
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
