using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NongSanVietNam.Models;

namespace NongSanVietNam.Areas.Admin.Controllers
{
    public class NongSansController : Controller
    {
        private NongSanVN db = new NongSanVN();

        // GET: Admin/NongSans
        public ActionResult Index()
        {
            var nongSans = db.NongSans.Include(n => n.LoaiN);
            return View(nongSans.ToList());
        }

        // GET: Admin/NongSans/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NongSan nongSan = db.NongSans.Find(id);
            if (nongSan == null)
            {
                return HttpNotFound();
            }
            return View(nongSan);
        }

        // GET: Admin/NongSans/Create
        public ActionResult Create()
        {
            ViewBag.IDLoaiNS = new SelectList(db.LoaiNS, "IDLoaiNS", "TenLoai");
            return View();
        }

        // POST: Admin/NongSans/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create([Bind(Include = "ID,TenNS,IDLoaiNS,MoTaNgan,MotaChiTiet,NgayTao,NguoiTao,NgayCapNhat,NguoiCapNhat,HinhAnhDaiDien")] NongSan nongSan)
        {
            if (ModelState.IsValid)
            {
                db.NongSans.Add(nongSan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IDLoaiNS = new SelectList(db.LoaiNS, "IDLoaiNS", "TenLoai", nongSan.IDLoaiNS);
            return View(nongSan);
        }

        // GET: Admin/NongSans/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NongSan nongSan = db.NongSans.Find(id);
            if (nongSan == null)
            {
                return HttpNotFound();
            }
            ViewBag.IDLoaiNS = new SelectList(db.LoaiNS, "IDLoaiNS", "TenLoai", nongSan.IDLoaiNS);
            return View(nongSan);
        }

        // POST: Admin/NongSans/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit([Bind(Include = "ID,TenNS,IDLoaiNS,MoTaNgan,MotaChiTiet,NgayTao,NguoiTao,NgayCapNhat,NguoiCapNhat,HinhAnhDaiDien")] NongSan nongSan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nongSan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IDLoaiNS = new SelectList(db.LoaiNS, "IDLoaiNS", "TenLoai", nongSan.IDLoaiNS);
            return View(nongSan);
        }

        // GET: Admin/NongSans/Delete/5
        [HttpPost]
        public ActionResult Delete(int[] id)
        {
            foreach (int i in id)
            {
                NongSan ns = db.NongSans.Find(i);
                db.NongSans.Remove(ns);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        // POST: Admin/NongSans/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    NongSan nongSan = db.NongSans.Find(id);
        //    db.NongSans.Remove(nongSan);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        public ActionResult Close()
        {
            return RedirectToAction("Index", "Default");
        }
    }
}
