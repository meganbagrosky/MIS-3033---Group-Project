using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HobbyLobby.Models;

namespace HobbyLobby.Controllers
{
    public class PickupController : Controller
    {
        private DB_128040_hobbylobbyEntities db = new DB_128040_hobbylobbyEntities();

        // GET: Pickup
        public ActionResult Index()
        {
            var pickups = db.Pickups.Include(p => p.Truck);
            var requests = db.Pickups.Include(r => r.Requests);
           // var store = db.Pickups.Include(s => s.Store);
            return View(pickups.ToList());
        }

        // GET: Pickup/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pickup pickup = db.Pickups.Find(id);
            if (pickup == null)
            {
                return HttpNotFound();
            }
            return View(pickup);
        }

        // GET: Pickup/Create
        public ActionResult Create()
        {
            ViewBag.TruckNumber = new SelectList(db.Trucks, "TruckNumber", "TruckNumber");
            ViewBag.Request = new SelectList(db.Requests, "PickupNumber", "PickupNumber");
            ViewBag.Location = new SelectList(db.Stores, "Location", "Location");
            return View();
        }

        public ActionResult PickupList()
        {
            var pickups = db.Pickups.Include(p => p.Truck);
            var requests = db.Pickups.Include(r => r.Requests);
            // var store = db.Pickups.Include(s => s.Store);
            return View(pickups.ToList());
        }

        // POST: Pickup/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PickupNumber,TruckNumber,ScheduledDate,PickupCapacity")] Pickup pickup)
        {
            if (ModelState.IsValid)
            {
                db.Pickups.Add(pickup);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TruckNumber = new SelectList(db.Trucks, "TruckNumber", "TruckNumber", pickup.TruckNumber);
            
            //ViewBag.StoreNumber = new SelectList(db.Stores, "Location", "Location", pickup.StoreNumber);
            return View(pickup);
        }

        // GET: Pickup/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pickup pickup = db.Pickups.Find(id);
            if (pickup == null)
            {
                return HttpNotFound();
            }
            ViewBag.TruckNumber = new SelectList(db.Trucks, "TruckNumber", "TruckNumber", pickup.TruckNumber);
            return View(pickup);
        }

        // POST: Pickup/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PickupNumber,TruckNumber,ScheduledDate,PickupCapacity")] Pickup pickup)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pickup).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TruckNumber = new SelectList(db.Trucks, "TruckNumber", "TruckNumber", pickup.TruckNumber);
            return View(pickup);
        }

        // GET: Pickup/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pickup pickup = db.Pickups.Find(id);
            if (pickup == null)
            {
                return HttpNotFound();
            }
            return View(pickup);
        }

        // POST: Pickup/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pickup pickup = db.Pickups.Find(id);
            db.Pickups.Remove(pickup);
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
