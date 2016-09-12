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
    public class EquipmentModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: EquipmentModels
        public ActionResult Index()
        {
            return View(db.EquipmentModels.ToList());
        }

        // GET: EquipmentModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EquipmentModel equipmentModel = db.EquipmentModels.Find(id);
            if (equipmentModel == null)
            {
                return HttpNotFound();
            }
            return View(equipmentModel);
        }

        // GET: EquipmentModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EquipmentModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ProducerName,ModelName")] EquipmentModel equipmentModel)
        {
            if (ModelState.IsValid)
            {
                db.EquipmentModels.Add(equipmentModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(equipmentModel);
        }

        // GET: EquipmentModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EquipmentModel equipmentModel = db.EquipmentModels.Find(id);
            if (equipmentModel == null)
            {
                return HttpNotFound();
            }
            return View(equipmentModel);
        }

        // POST: EquipmentModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ProducerName,ModelName")] EquipmentModel equipmentModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(equipmentModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(equipmentModel);
        }

        // GET: EquipmentModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EquipmentModel equipmentModel = db.EquipmentModels.Find(id);
            if (equipmentModel == null)
            {
                return HttpNotFound();
            }
            return View(equipmentModel);
        }

        // POST: EquipmentModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EquipmentModel equipmentModel = db.EquipmentModels.Find(id);
            db.EquipmentModels.Remove(equipmentModel);
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
