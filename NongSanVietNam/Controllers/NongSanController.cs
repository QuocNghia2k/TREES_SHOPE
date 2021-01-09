using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NongSanVietNam.Models;

namespace NongSanVietNam.Controllers
{
    public class NongSanController : Controller
    {
        private NongSanVN db = new NongSanVN();
        // GET: NongSan
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult NongSanMoi()
        {
            var nsm = db.NongSans.OrderByDescending(s => s.ID).ToList().Take(6);
            return PartialView(nsm);
        }
        [HttpGet]
        public ActionResult DanhMucNS(int id)
        {
            var ds = db.NongSans.Where(s => s.IDLoaiNS == id).ToList();
            ViewBag.tenloai = db.LoaiNS.Where(s => s.IDLoaiNS == id).ToList().FirstOrDefault().TenLoai;
            ViewBag.dssp = db.NongSans.Where(s => s.IDLoaiNS == id).ToList();
            return View(ds);
        }
        [HttpGet]
        public ActionResult ChiTietNS(int id)
        {
            var ns = db.NongSans.Where(s => s.ID == id).ToList().FirstOrDefault();
            ViewBag.nslq = db.NongSans.Where(s => s.IDLoaiNS == ns.IDLoaiNS && s.ID != ns.ID).ToList().Take(3);
            return View(ns);
        }
        [HttpGet]
        public ActionResult TimKiemNS(string tenNS)
        {
            var ns = db.NongSans.Where(s => s.TenNS.Contains(tenNS)).ToList();
            ViewBag.dsns = db.NongSans.Where(s => s.TenNS.Contains(tenNS)).ToList();
            return View(ns);
        }
    }
}