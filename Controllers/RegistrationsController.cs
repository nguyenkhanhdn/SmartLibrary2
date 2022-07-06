using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SmartLibrary2.Models;

namespace SmartLibrary2.Controllers
{
    public class RegistrationsController : Controller
    {
        private BookRevEntities db = new BookRevEntities();

        // GET: Registrations
        public ActionResult Index()
        {
            return View(db.BookRegistrations.ToList());
        }

        // GET: Registrations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookRegistration bookRegistration = db.BookRegistrations.Find(id);
            if (bookRegistration == null)
            {
                return HttpNotFound();
            }
            return View(bookRegistration);
        }

        // GET: Registrations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Registrations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,UserId,BookId,RegDate,Note,ShipMethod,Status")] BookRegistration bookRegistration)
        {
            if (ModelState.IsValid)
            {
                db.BookRegistrations.Add(bookRegistration);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bookRegistration);
        }

        // GET: Registrations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookRegistration bookRegistration = db.BookRegistrations.Find(id);
            if (bookRegistration == null)
            {
                return HttpNotFound();
            }
            return View(bookRegistration);
        }

        // POST: Registrations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,UserId,BookId,RegDate,Note,ShipMethod,Status")] BookRegistration bookRegistration)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bookRegistration).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bookRegistration);
        }

        // GET: Registrations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookRegistration bookRegistration = db.BookRegistrations.Find(id);
            if (bookRegistration == null)
            {
                return HttpNotFound();
            }
            return View(bookRegistration);
        }

        // POST: Registrations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BookRegistration bookRegistration = db.BookRegistrations.Find(id);
            db.BookRegistrations.Remove(bookRegistration);
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
