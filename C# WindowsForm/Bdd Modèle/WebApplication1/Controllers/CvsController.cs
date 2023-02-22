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
    public class CvsController : Controller
    {
        private baeEntities db = new baeEntities();

        // GET: Cvs
        public ActionResult Index()
        {
            var cv = db.Cv.Include(c => c.Competence).Include(c => c.Profile);
            return View(cv.ToList());
        }

        // GET: Cvs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cv cv = db.Cv.Find(id);
            if (cv == null)
            {
                return HttpNotFound();
            }
            return View(cv);
        }

        // GET: Cvs/Create
        public ActionResult Create()
        {
            ViewBag.IdCompetence = new SelectList(db.Competence, "IdCompetence", "ListeCompetence");
            ViewBag.IdProfile = new SelectList(db.Profile, "IdProfile", "IdProfile");
            return View();
        }

        // POST: Cvs/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdCv,NomCv,Url,Date,IdCompetence,IdProfile")] Cv cv)
        {
            if (ModelState.IsValid)
            {
                db.Cv.Add(cv);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdCompetence = new SelectList(db.Competence, "IdCompetence", "ListeCompetence", cv.IdCompetence);
            ViewBag.IdProfile = new SelectList(db.Profile, "IdProfile", "IdProfile", cv.IdProfile);
            return View(cv);
        }

        // GET: Cvs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cv cv = db.Cv.Find(id);
            if (cv == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdCompetence = new SelectList(db.Competence, "IdCompetence", "ListeCompetence", cv.IdCompetence);
            ViewBag.IdProfile = new SelectList(db.Profile, "IdProfile", "IdProfile", cv.IdProfile);
            return View(cv);
        }

        // POST: Cvs/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdCv,NomCv,Url,Date,IdCompetence,IdProfile")] Cv cv)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cv).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdCompetence = new SelectList(db.Competence, "IdCompetence", "ListeCompetence", cv.IdCompetence);
            ViewBag.IdProfile = new SelectList(db.Profile, "IdProfile", "IdProfile", cv.IdProfile);
            return View(cv);
        }

        // GET: Cvs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cv cv = db.Cv.Find(id);
            if (cv == null)
            {
                return HttpNotFound();
            }
            return View(cv);
        }

        // POST: Cvs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cv cv = db.Cv.Find(id);
            db.Cv.Remove(cv);
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
