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
    public class StoresController : Controller
    {
        private DB_128040_hobbylobbyEntities db = new DB_128040_hobbylobbyEntities();

        // GET: Stores
        public ActionResult Index()
        {
            return View(db.Stores.ToList());
        }

        // GET: Stores/Details/5
        public ActionResult Details(int? id)
        {
            List<Request> request = new List<Request>();
            List<Pickup> pickup = new List<Pickup>();
            foreach (var r in db.Requests)
            {
                if (r.StoreNumber == id)
                {
                    request.Add(r);
                }
            }
            foreach (var p in db.Pickups)
            {
                foreach (var r in request)
                {
                    if (p.PickupNumber==r.PickupNumber)
                    {
                        pickup.Add(p);
                    }
                }
            }

            var tables = new StoreRequestView
            {
                PickupClass = pickup,
                RequestClass = request,
                StoreClass = db.Stores.Find(id),
                RequestName = db.Requests.Find(id),
                PickUpName = db.Pickups.Find(id)
            };
            return View(tables);
        }

        // GET: Stores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Stores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StoreNumber,Location,StreetAddress,City,State")] Store store)
        {
            if (ModelState.IsValid)
            {
                db.Stores.Add(store);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(store);
        }

        // GET: Stores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Store store = db.Stores.Find(id);
            if (store == null)
            {
                return HttpNotFound();
            }
            return View(store);
        }

        // POST: Stores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Store store = db.Stores.Find(id);
            db.Stores.Remove(store);
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


