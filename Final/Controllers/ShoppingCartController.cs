using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Final.Context;

namespace Final.Controllers
{
    public class ShoppingCartController : Controller
    {
        Final_ProjectEntities1 objDB = new Final_ProjectEntities1();
        // GET: ShoppingCart

        public Cart GetCart()
        {
            Cart cart = Session["Cart"] as Cart;
            if(cart == null || Session["Cart"] == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }
       public ActionResult AddToCart(int id)
        {
            if (Session["idUser"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            var pro = objDB.products.SingleOrDefault(s => s.pd_id == id);
            if (pro != null)
            {
                GetCart().Add(pro);
            }
            return RedirectToAction("ShowToCart", "ShoppingCart");
        }

        public ActionResult ShowToCart()
        {
            if (Session["Cart"] == null)
            {
                return RedirectToAction("ShowToCart", "ShoppingCart");
            }
            Cart cart = Session["Cart"] as Cart;
            return View(cart);
        }
        public ActionResult Update_Qty(FormCollection form)
        {
            Cart cart = Session["Cart"] as Cart;
            int id_pd = int.Parse(form["ID_Product"]);
            int quantity = int.Parse(form["Quantity"]);
            cart.Update_Quantity(id_pd, quantity);
            return RedirectToAction("ShowToCart", "ShoppingCart");
        }
        public ActionResult RemoveItem(int id)
        {
            Cart cart = Session["Cart"] as Cart;
            cart.Remove(id);
            return RedirectToAction("ShowToCart", "ShoppingCart");
        }
        
        public PartialViewResult BagCart()
        {
            int t_item = 0;
            Cart cart = Session["Cart"] as Cart;
            if (cart != null)
            {
                t_item = cart.TotalItem();
            }
            ViewBag.infoCart = t_item;
            return PartialView("BagCart");
        }

        public ActionResult ShoppingSuccess()
        {
            return View();
        }

        public ActionResult Payment(FormCollection form)
        {
            try
            {
                Cart cart = Session["Cart"] as Cart;
                shipping shp = new shipping();
                shp.shipping_created = DateTime.Now;
                shp.users_id = int.Parse(form["UserId"]);
                shp.address = form["User_Address"];
                shp.total_price = cart.Total_Price();
                objDB.shippings.Add(shp);

                foreach(var item in cart.Items)
                {
                    order ord = new order();
                    ord.shipping_id = shp.shipping_id;
                    ord.pd_id = item.shopping_product.pd_id;
                    ord.UnitPriceSale = item.shopping_product.pd_price;
                    ord.QuantitySale = item.shopping_quantity;
                    ord.order_created = DateTime.Now;
                    objDB.orders.Add(ord);
                }
                objDB.SaveChanges();
                cart.ClearAll();
                return RedirectToAction("ShoppingSuccess", "ShoppingCart");
            }
            catch
            {
                return Content("XẢY RA LỖI");
            }
        }
    }
}