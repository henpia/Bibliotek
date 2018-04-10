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
    public class BogController : Controller
    {
        private BibliotekContext db = new BibliotekContext();

        // GET: Bog
        public ActionResult Index()
        {
            return View(db.Boeger.ToList());
        }

        // GET: Bog/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bog bog = db.Boeger.Find(id);
            if (bog == null)
            {
                return HttpNotFound();
            }
            return View(bog);
        }

        // GET: Bog/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bog/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BogId,Titel,Beskrivelse,ImageURL")] Bog bog)
        {
            if (ModelState.IsValid)
            {
                db.Boeger.Add(bog);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bog);
        }

        // GET: Bog/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bog bog = db.Boeger.Find(id);
            if (bog == null)
            {
                return HttpNotFound();
            }
            return View(bog);
        }

        // POST: Bog/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BogId,Titel,Beskrivelse,ImageURL")] Bog bog)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bog).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bog);
        }

        // GET: Bog/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bog bog = db.Boeger.Find(id);
            if (bog == null)
            {
                return HttpNotFound();
            }
            return View(bog);
        }

        // POST: Bog/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bog bog = db.Boeger.Find(id);
            db.Boeger.Remove(bog);
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
