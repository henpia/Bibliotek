using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Bibliotek.Models;

namespace Bibliotek.Controllers
{
    public class ForfatterController : Controller
    {
        private BibliotekContext db = new BibliotekContext();

        // GET: Forfatter
        public ActionResult Index()
        {
            return View(db.Forfattere.ToList());
        }

        // GET: Forfatter/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Forfatter forfatter = db.Forfattere.Find(id);
            if (forfatter == null)
            {
                return HttpNotFound();
            }
            return View(forfatter);
        }

        // GET: Forfatter/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Forfatter/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ForfatterId,Navn,Beskrivelse")] Forfatter forfatter)
        {
            if (ModelState.IsValid)
            {
                db.Forfattere.Add(forfatter);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(forfatter);
        }

        // GET: Forfatter/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Forfatter forfatter = db.Forfattere.Find(id);
            if (forfatter == null)
            {
                return HttpNotFound();
            }
            return View(forfatter);
        }

        // POST: Forfatter/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ForfatterId,Navn,Beskrivelse")] Forfatter forfatter)
        {
            if (ModelState.IsValid)
            {
                db.Entry(forfatter).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(forfatter);
        }

        // GET: Forfatter/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Forfatter forfatter = db.Forfattere.Find(id);
            if (forfatter == null)
            {
                return HttpNotFound();
            }
            return View(forfatter);
        }

        // POST: Forfatter/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Forfatter forfatter = db.Forfattere.Find(id);
            db.Forfattere.Remove(forfatter);
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
