using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Part_5.Models;

namespace Part_5.Controllers
{
    [Authorize]
    public class HealthCoachesController : Controller
    {
        private Part_5Context db = new Part_5Context();

        [AllowAnonymous]
        // GET: HealthCoaches
        public ActionResult Index()
        {
            return View(db.HealthCoaches.ToList());
        }

        // GET: HealthCoaches/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HealthCoaches healthCoaches = db.HealthCoaches.Find(id);
            if (healthCoaches == null)
            {
                return HttpNotFound();
            }
            return View(healthCoaches);
        }

        // GET: HealthCoaches/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HealthCoaches/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HealthCoachesId,FirstName,LastName")] HealthCoaches healthCoaches)
        {
            if (ModelState.IsValid)
            {
                db.HealthCoaches.Add(healthCoaches);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(healthCoaches);
        }

        // GET: HealthCoaches/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HealthCoaches healthCoaches = db.HealthCoaches.Find(id);
            if (healthCoaches == null)
            {
                return HttpNotFound();
            }
            return View(healthCoaches);
        }

        // POST: HealthCoaches/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HealthCoachesId,FirstName,LastName")] HealthCoaches healthCoaches)
        {
            if (ModelState.IsValid)
            {
                db.Entry(healthCoaches).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(healthCoaches);
        }

        // GET: HealthCoaches/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HealthCoaches healthCoaches = db.HealthCoaches.Find(id);
            if (healthCoaches == null)
            {
                return HttpNotFound();
            }
            return View(healthCoaches);
        }

        // POST: HealthCoaches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HealthCoaches healthCoaches = db.HealthCoaches.Find(id);
            db.HealthCoaches.Remove(healthCoaches);
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
