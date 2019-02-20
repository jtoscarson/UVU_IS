using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Part_7_UV_registry.Models;

namespace Part_7_UV_registry.Controllers
{
    public class InmatesController : Controller
    {
        private Part_7_UV_registryDb db = new Part_7_UV_registryDb();

        // GET: Inmates
        public ActionResult Index()
        {
            return View(db.Inmates.ToList());
        }

        // GET: Inmates/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inmate inmate = db.Inmates.Find(id);
            if (inmate == null)
            {
                return HttpNotFound();
            }
            return View(inmate);
        }

        // GET: Inmates/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Inmates/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "InmateId,FirstName,LastName")] Inmate inmate)
        {
            if (ModelState.IsValid)
            {
                db.Inmates.Add(inmate);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(inmate);
        }

        // GET: Inmates/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inmate inmate = db.Inmates.Find(id);
            if (inmate == null)
            {
                return HttpNotFound();
            }
            return View(inmate);
        }

        // POST: Inmates/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "InmateId,FirstName,LastName")] Inmate inmate)
        {
            if (ModelState.IsValid)
            {
                db.Entry(inmate).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(inmate);
        }

        // GET: Inmates/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inmate inmate = db.Inmates.Find(id);
            if (inmate == null)
            {
                return HttpNotFound();
            }
            return View(inmate);
        }

        // POST: Inmates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Inmate inmate = db.Inmates.Find(id);
            db.Inmates.Remove(inmate);
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
