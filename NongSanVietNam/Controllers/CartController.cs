using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NongSanVietNam.DAO;
using NongSanVietNam.Models;

namespace NongSanVietNam.Controllers
{
    public class CartController : Controller
    {
        public const String CartSession = "CartSession";
        // GET: Cart
        public ActionResult Index()
        {
            var cart = Session[CartSession];
            var list = new List<CartItem>();

            var total = 0;
            var count = 0;
            if (cart != null)
            {
                list = (List<CartItem>)cart;
                foreach (var item in list)
                {
                    count++;
                    total += item.Product.Gia * item.Quantity;
                }
            }
            else
            {
                total = 0;
            }
            ViewBag.q = total;
            ViewBag.c = count;
            return View(list);
        }
        public ActionResult AddItem(int productID, int quantity)
        {
            var product = new ProductDAO().getByID(productID);
            var cart = Session[CartSession];
            if (cart != null)
            {
                var list = (List<CartItem>)cart;

                if (list.Exists(x => x.Product.ID == productID))
                {
                    foreach (var item in list)
                    {
                        if (item.Product.ID == productID)
                            item.Quantity += quantity;
                    }
                }
                else
                {
                    var item = new CartItem();
                    item.Product = product;
                    item.Quantity = quantity;
                    list.Add(item);
                }
                //dua vao session
                Session[CartSession] = list;
            }
            else
            {
                //Tao moi cart
                var item = new CartItem();
                item.Product = product;
                item.Quantity = quantity;
                var list = new List<CartItem>();
                list.Add(item);
                //dua vao session
                Session[CartSession] = list;

            }
            return RedirectToAction("Index");
        }
        public ActionResult RemoveItem(int productID)
        {
            
            var cart = Session[CartSession];
            CartItem s = null;
            if (cart != null)
            {
                var list = (List<CartItem>)cart;

                if (list.Exists(x => x.Product.ID == productID))
                {
                    foreach (var item in list)
                    {
                        if (item.Product.ID == productID)
                        {
                            s = item;
                        }


                    }
                    list.Remove(s);
                }
               
                Session[CartSession] = list;
            }
            else
            {
               
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult UpdateItem(CartModel cartmodel)

        {
            try
            {
                int productID = int.Parse(cartmodel.ID);

                int quantity = int.Parse(cartmodel.Quantity);

                var product = new ProductDAO().getByID(productID);
                var cart = Session[CartSession];
                if (cart != null)
                {
                    var list = (List<CartItem>)cart;

                    if (list.Exists(x => x.Product.ID == productID))
                    {
                        foreach (var item in list)
                        {
                            if (item.Product.ID == productID)
                            {
                                if (quantity > 1)
                                {
                                    item.Quantity = quantity;
                                }
                            }

                        }
                    }

                    //Session[CartSession] = list;
                }
                else
                {

                }
            }catch (System.FormatException e)
            {

            }
            return RedirectToAction("Index");
        }
    }
}