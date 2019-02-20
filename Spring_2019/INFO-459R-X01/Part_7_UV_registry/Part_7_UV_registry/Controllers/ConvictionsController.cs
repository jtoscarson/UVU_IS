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
    public class ConvictionsController : Controller
    {
        private Part_7_UV_registryDb db = new Part_7_UV_registryDb();

        // GET: Convictions
        public ActionResult Index()
        {
            return View(db.Convictions.Include(x => x.Inmate).ToList());
        }

        // GET: Convictions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Conviction conviction = db.Convictions.Find(id);
            if (conviction == null)
            {
                return HttpNotFound();
            }
            return View(conviction);
        }

        // GET: Convictions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Convictions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ConvictionId,Type,Description,ConvictionDate")] Conviction conviction)
        {
            if (ModelState.IsValid)
            {
                db.Convictions.Add(conviction);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(conviction);
        }

        // GET: Convictions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Conviction conviction = db.Convictions.Find(id);
            if (conviction == null)
            {
                return HttpNotFound();
            }
            return View(conviction);
        }

        // POST: Convictions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ConvictionId,Type,Description,ConvictionDate")] Conviction conviction)
        {
            if (ModelState.IsValid)
            {
                db.Entry(conviction).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(conviction);
        }

        // GET: Convictions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Conviction conviction = db.Convictions.Find(id);
            if (conviction == null)
            {
                return HttpNotFound();
            }
            return View(conviction);
        }

        // POST: Convictions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Conviction conviction = db.Convictions.Find(id);
            db.Convictions.Remove(conviction);
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
