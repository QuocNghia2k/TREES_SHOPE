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
    public class LoaiNsController : Controller
    {
        private NongSanVN db = new NongSanVN();

        // GET: Admin/LoaiNs
        public ActionResult Index()
        {
            return View(db.LoaiNS.ToList());
        }

        // GET: Admin/LoaiNs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiN loaiN = db.LoaiNS.Find(id);
            if (loaiN == null)
            {
                return HttpNotFound();
            }
            return View(loaiN);
        }

        // GET: Admin/LoaiNs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/LoaiNs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create([Bind(Include = "IDLoaiNS,TenLoai,HinhAnh,MotaNgan,NguoiTao,NgayTao,NguoiCapNhat,NgayCapNhat")] LoaiN loaiN)
        {
            if (ModelState.IsValid)
            {
                db.LoaiNS.Add(loaiN);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(loaiN);
        }

        // GET: Admin/LoaiNs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiN loaiN = db.LoaiNS.Find(id);
            if (loaiN == null)
            {
                return HttpNotFound();
            }
            return View(loaiN);
        }

        // POST: Admin/LoaiNs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit([Bind(Include = "IDLoaiNS,TenLoai,HinhAnh,MotaNgan,NguoiTao,NgayTao,NguoiCapNhat,NgayCapNhat")] LoaiN loaiN)
        {
            if (ModelState.IsValid)
            {
                db.Entry(loaiN).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(loaiN);
        }

        // GET: Admin/LoaiNs/Delete/5
        [HttpPost]
        public ActionResult Delete(int[] id)
        {
            foreach(int i in id)
            {
                LoaiN lns = db.LoaiNS.Find(i);
                var dsns = db.NongSans.Where(s => s.IDLoaiNS == i).ToList();
                if(dsns.Count > 0)
                {
                    foreach(var ns in dsns)
                    {
                        db.NongSans.Remove(ns);
                        db.SaveChanges();
                    }
                }

                db.LoaiNS.Remove(lns);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        // POST: Admin/LoaiNs/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    LoaiN loaiN = db.LoaiNS.Find(id);
        //    db.LoaiNS.Remove(loaiN);
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
