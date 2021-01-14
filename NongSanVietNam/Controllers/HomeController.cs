using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NongSanVietNam.Models;

namespace NongSanVietNam.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        NongSanVN db = new NongSanVN();
        public ActionResult Index()
        {
            var cart = Session["CartSession"];
            var list = new List<CartItem>();

            var count = 0;
            if (cart != null)
            {
                list = (List<CartItem>)cart;
                foreach (var item in list)
                {
                    count++;
                   
                }
            }
            else
            {
                count = 0;
            }
          
            ViewBag.co = count;
            return View();
        }
        public PartialViewResult LeftMenu()
        {
            var Catalog = db.LoaiNS.OrderBy(s => s.NgayTao).ToList();
            return PartialView(Catalog);
        }

        public PartialViewResult Menu()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult TimkiemNS(string txtTimKiem)
        {
            List<NongSan> kqtk = db.NongSans.Where(s => s.TenNS.Contains(txtTimKiem)).ToList();

            if (kqtk.Count != 0)
            {
                return PartialView(kqtk);
            }
            else
            {
                ViewBag.thongbao = "Không tìm thấy sản phẩm cần tìm";
                return View();
            }
        }
    }
}