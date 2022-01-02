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
    [Authorize]
    public class LopHoc358Controller : Controller
    {
        private LTQLDBContex db = new LTQLDBContex();
        [AllowAnonymous]
        // GET: LopHoc358
        public ActionResult Index()
        {
            return View(db.LopHoc358s.ToList());
        }
        [AllowAnonymous]
        // GET: LopHoc358/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LopHoc358 lopHoc358 = db.LopHoc358s.Find(id);
            if (lopHoc358 == null)
            {
                return HttpNotFound();
            }
            return View(lopHoc358);
        }

        // GET: LopHoc358/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LopHoc358/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Malop,TenLop")] LopHoc358 lopHoc358)
        {
            if (ModelState.IsValid)
            {
                db.LopHoc358s.Add(lopHoc358);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lopHoc358);
        }

        // GET: LopHoc358/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LopHoc358 lopHoc358 = db.LopHoc358s.Find(id);
            if (lopHoc358 == null)
            {
                return HttpNotFound();
            }
            return View(lopHoc358);
        }

        // POST: LopHoc358/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Malop,TenLop")] LopHoc358 lopHoc358)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lopHoc358).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lopHoc358);
        }

        // GET: LopHoc358/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LopHoc358 lopHoc358 = db.LopHoc358s.Find(id);
            if (lopHoc358 == null)
            {
                return HttpNotFound();
            }
            return View(lopHoc358);
        }

        // POST: LopHoc358/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LopHoc358 lopHoc358 = db.LopHoc358s.Find(id);
            db.LopHoc358s.Remove(lopHoc358);
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
