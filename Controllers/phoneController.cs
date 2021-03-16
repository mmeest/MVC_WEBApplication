using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_WEBApplication.Models;

namespace MVC_WEBApplication.Controllers
{
    public class phoneController : Controller
    {
        private MobileEntities db = new MobileEntities();

        // GET: phone
        public ActionResult Index()
        {
            return View(db.phones.ToList());
        }

        // GET: phone/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    phone phone = db.phones.Find(id);
        //    if (phone == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(phone);
        //}

        // GET: phone/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: phone/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Brand_Name,Model_Name,Launch,Camera,Ram,Battery,Network,weight,Memory")] phone phone)
        {
            if (ModelState.IsValid)
            {
                db.phones.Add(phone);
                db.SaveChanges();
                TempData["SuccessMessage"] = "New Record Added Successfuly!";
                return RedirectToAction("Index");
            }

            return View(phone);
        }

        // GET: phone/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            phone phone = db.phones.Find(id);
            if (phone == null)
            {
                return HttpNotFound();
            }
            return View(phone);
        }

        // POST: phone/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Brand_Name,Model_Name,Launch,Camera,Ram,Battery,Network,weight,Memory")] phone phone)
        {
            if (ModelState.IsValid)
            {
                db.Entry(phone).State = EntityState.Modified;
                db.SaveChanges();
                TempData["SuccessMessage"] = "Record Edited Successfuly!";
                return RedirectToAction("Index");
            }
            return View(phone);
        }

        // GET: phone/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            phone phone = db.phones.Find(id);
            if (phone == null)
            {
                return HttpNotFound();
            }
            return View(phone);
        }

        // POST: phone/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            phone phone = db.phones.Find(id);
            db.phones.Remove(phone);
            db.SaveChanges();
            TempData["SuccessMessage"] = "Record Deleted Successfuly!";
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
