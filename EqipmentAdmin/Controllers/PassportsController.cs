using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EqipmentAdmin.Models;

namespace EqipmentAdmin.Controllers
{
    public class PassportsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Passports
        public ActionResult Index()
        {
            return View(db.Passports.ToList());
        }

        // GET: Passports/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Passport passport = db.Passports.Find(id);
            if (passport == null)
            {
                return HttpNotFound();
            }
            return View(passport);
        }

        // GET: Passports/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Passports/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CreateDate")] Passport passport)
        {
            if (ModelState.IsValid)
            {
                db.Passports.Add(passport);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(passport);
        }

        // GET: Passports/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Passport passport = db.Passports.Find(id);
            if (passport == null)
            {
                return HttpNotFound();
            }
            return View(passport);
        }

        // POST: Passports/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CreateDate")] Passport passport)
        {
            if (ModelState.IsValid)
            {
                db.Entry(passport).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(passport);
        }

        // GET: Passports/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Passport passport = db.Passports.Find(id);
            if (passport == null)
            {
                return HttpNotFound();
            }
            return View(passport);
        }

        // POST: Passports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Passport passport = db.Passports.Find(id);
            db.Passports.Remove(passport);
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
