using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NongSanVietNam.Models;

namespace NongSanVietNam.Controllers
{
    public class TinTucController : Controller
    {
        private NongSanVN db = new NongSanVN();
        // GET: TinTuc
        public ActionResult Index()
        {
            var tm = db.TinTucs.OrderByDescending(s => s.IDTinTuc).ToList().Take(5);
            ViewBag.tmoi = db.TinTucs.OrderByDescending(s => s.IDTinTuc).ToList().Take(5);
            return View(tm);
        }
        [HttpGet]
        public ActionResult ChiTietTin(int id)
        {
            var tin = db.TinTucs.Where(s => s.IDTinTuc == id).ToList().FirstOrDefault();
            ViewBag.tinkhac = db.TinTucs.Where(s => s.IDTinTuc != tin.IDTinTuc).ToList().Take(3);
            return View(tin);
        }
    }
}