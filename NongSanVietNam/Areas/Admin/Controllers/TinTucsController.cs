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
    public class TinTucsController : Controller
    {
        private NongSanVN db = new NongSanVN();

        // GET: Admin/TinTucs
        public ActionResult Index()
        {
            var tinTucs = db.TinTucs.Include(t => t.NguoiDung);
            return View(tinTucs.ToList());
        }

        // GET: Admin/TinTucs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TinTuc tinTuc = db.TinTucs.Find(id);
            if (tinTuc == null)
            {
                return HttpNotFound();
            }
            return View(tinTuc);
        }

        // GET: Admin/TinTucs/Create
        public ActionResult Create()
        {
            ViewBag.UserID = new SelectList(db.NguoiDungs, "UserID", "TaiKhoan");
            return View();
        }

        // POST: Admin/TinTucs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create([Bind(Include = "IDTinTuc,TieuDe,MotaNgan,BaiVietChiTiet,UserID,NgayTao,NgayCapNhat,HinhAnhDaiDien")] TinTuc tinTuc)
        {
            if (ModelState.IsValid)
            {
                db.TinTucs.Add(tinTuc);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UserID = new SelectList(db.NguoiDungs, "UserID", "TaiKhoan", tinTuc.UserID);
            return View(tinTuc);
        }

        // GET: Admin/TinTucs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TinTuc tinTuc = db.TinTucs.Find(id);
            if (tinTuc == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserID = new SelectList(db.NguoiDungs, "UserID", "TaiKhoan", tinTuc.UserID);
            return View(tinTuc);
        }

        // POST: Admin/TinTucs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit([Bind(Include = "IDTinTuc,TieuDe,MotaNgan,BaiVietChiTiet,UserID,NgayTao,NgayCapNhat,HinhAnhDaiDien")] TinTuc tinTuc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tinTuc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UserID = new SelectList(db.NguoiDungs, "UserID", "TaiKhoan", tinTuc.UserID);
            return View(tinTuc);
        }
        [HttpPost]
        // GET: Admin/TinTucs/Delete/5
        public ActionResult Delete(int[] id)
        {
            foreach (int i in id)
            {
                TinTuc tt = db.TinTucs.Find(i);
                db.TinTucs.Remove(tt);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        // POST: Admin/TinTucs/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    TinTuc tinTuc = db.TinTucs.Find(id);
        //    db.TinTucs.Remove(tinTuc);
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
