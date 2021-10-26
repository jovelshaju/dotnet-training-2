using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCWithDB.Models;

namespace MVCWithDB.Controllers
{
    public class FeesController : Controller
    {
        private Day18DBEntities db = new Day18DBEntities();

        // GET: Fees
        public ActionResult Index()
        {
            var fees = db.Fees.Include(f => f.Student);
            return View(fees.ToList());
        }

        // GET: Fees/Details/5
        public ActionResult Details(int? id, int? month, int? year)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fee fee = db.Fees.Find(id,month,year);
            if (fee == null)
            {
                return HttpNotFound();
            }
            return View(fee);
        }

        // GET: Fees/Create
        public ActionResult Create()
        {
            ViewBag.SId = new SelectList(db.Students, "SId", "SName");
            return View(new Fee());
        }

        // POST: Fees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SId,SFee,SMonth,SYear")] Fee fee)
        {
            if (ModelState.IsValid)
            {
                db.Fees.Add(fee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SId = new SelectList(db.Students, "SId", "SName", fee.SId);
            return View(fee);
        }

        // GET: Fees/Edit/5
        public ActionResult Edit(int? id, int? month, int? year)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fee fee = db.Fees.Find(id, month, year);
            if (fee == null)
            {
                return HttpNotFound();
            }
            ViewBag.SId = new SelectList(db.Students, "SId", "SName", fee.SId);
            return View(fee);
        }

        // POST: Fees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SId,SFee,SMonth,SYear")] Fee fee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SId = new SelectList(db.Students, "SId", "SName", fee.SId);
            return View(fee);
        }

        // GET: Fees/Delete/5
        public ActionResult Delete(int? id, int? month, int? year)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fee fee = db.Fees.Find(id, month, year);
            if (fee == null)
            {
                return HttpNotFound();
            }
            return View(fee);
        }

        // POST: Fees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id, int month, int year)
        {
            Fee fee = db.Fees.Find(id, month, year);
            db.Fees.Remove(fee);
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
