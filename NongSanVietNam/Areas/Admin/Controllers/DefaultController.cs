using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NongSanVietNam.Models;

namespace NongSanVietNam.Areas.Admin.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Admin/Default
        NongSanVN db = new NongSanVN();
        
        public ActionResult Index()
        {
            if (string.IsNullOrEmpty(Session["ten"].ToString()))
            {
                return RedirectToAction("Login");
            }
            else
            {
                return View();
            }
        }
        public PartialViewResult Menu()
        {
            return PartialView();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string txtTen, string txtMK)
        {
            var user = db.NguoiDungs.Where(s => s.TaiKhoan == txtTen && s.MatKhau == txtMK).ToList();
            if(user.Count!=0)
            {
                Session["ten"] = txtTen;
                Session["pass"] = txtMK;
                return RedirectToAction("Index");
            }
            else
            {
                return View();//Response.Write("<script>alert('Đăng nhập không thành công')</script>");
            }
            
        }
        public ActionResult Thoat()
        {
            Session["ten"] = "";
            Session["pass"] = "";
            return RedirectToAction("Login");
        }
    }
}