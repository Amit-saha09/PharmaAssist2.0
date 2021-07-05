using PharmaAssist2._0.Models;
using PharmaAssist2._0.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PharmaAssist2._0.Controllers
{
    public class CartController : Controller
    {
        CartRepository contex = new CartRepository();
        // GET: Cart
        public ActionResult Add(Cart cart)
        {
            cart.Totalprice = (cart.Price * cart.Quantity);
            cart.ConsumerId = (int)Session["logged_id"];

            contex.Insert(cart);



            return RedirectToAction("Index", "Product");
        }
    }
}