using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LTQL_1721050358.Models;

namespace LTQL_1721050358.Controllers
{
    public class THQSinhVien358Controller : Controller
    {
        private LTQLDBContex db = new LTQLDBContex();

        // GET: THQSinhVien358
        public ActionResult Index()
        {
            return View(db.THQSinhVien358s.ToList());
        }

        // GET: THQSinhVien358/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            THQSinhVien358 tHQSinhVien358 = db.THQSinhVien358s.Find(id);
            if (tHQSinhVien358 == null)
            {
                return HttpNotFound();
            }
            return View(tHQSinhVien358);
        }

        // GET: THQSinhVien358/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: THQSinhVien358/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaSinhVien,HoTen,MaLop")] THQSinhVien358 tHQSinhVien358)
        {
            if (ModelState.IsValid)
            {
                db.THQSinhVien358s.Add(tHQSinhVien358);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tHQSinhVien358);
        }

        // GET: THQSinhVien358/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            THQSinhVien358 tHQSinhVien358 = db.THQSinhVien358s.Find(id);
            if (tHQSinhVien358 == null)
            {
                return HttpNotFound();
            }
            return View(tHQSinhVien358);
        }

        // POST: THQSinhVien358/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaSinhVien,HoTen,MaLop")] THQSinhVien358 tHQSinhVien358)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tHQSinhVien358).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tHQSinhVien358);
        }

        // GET: THQSinhVien358/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            THQSinhVien358 tHQSinhVien358 = db.THQSinhVien358s.Find(id);
            if (tHQSinhVien358 == null)
            {
                return HttpNotFound();
            }
            return View(tHQSinhVien358);
        }

        // POST: THQSinhVien358/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            THQSinhVien358 tHQSinhVien358 = db.THQSinhVien358s.Find(id);
            db.THQSinhVien358s.Remove(tHQSinhVien358);
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
