using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Remindz.Models;

namespace Remindz
{
    public class DateController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Date
        public ActionResult Index()
        {
            return View(db.Rdates.ToList());
        }

        // GET: Date/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rdate rdate = db.Rdates.Find(id);
            if (rdate == null)
            {
                return HttpNotFound();
            }
            return View(rdate);
        }

        // GET: Date/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Date/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RdateId,EventDate,ReminderDate,Name,Completed")] Rdate rdate)
        {
            if (ModelState.IsValid)
            {
                db.Rdates.Add(rdate);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rdate);
        }

        // GET: Date/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rdate rdate = db.Rdates.Find(id);
            if (rdate == null)
            {
                return HttpNotFound();
            }
            return View(rdate);
        }

        // POST: Date/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RdateId,EventDate,ReminderDate,Name,Completed")] Rdate rdate)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rdate).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rdate);
        }

        // GET: Date/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rdate rdate = db.Rdates.Find(id);
            if (rdate == null)
            {
                return HttpNotFound();
            }
            return View(rdate);
        }

        // POST: Date/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Rdate rdate = db.Rdates.Find(id);
            db.Rdates.Remove(rdate);
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
