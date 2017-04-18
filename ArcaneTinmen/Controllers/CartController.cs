using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArcaneTinmen.Models;
using ArcaneTinmen.ViewModels;
using ArcaneTinmen.Infrastructure;

namespace ArcaneTinmen.Controllers
{
    public class CartController : Controller
    {
        private ArcaneTinmenDBContext db;
        // constructor
        // instantiale a new repository object
        public CartController()
        {
            db = new ArcaneTinmenDBContext();
        }

        public ViewResult Index(Cart cart, string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = cart,
                ReturnUrl = returnUrl
            });
        }

        public RedirectToRouteResult AddToCart(Cart cart, int productId, string returnUrl)
        {
            Product product = db.Product.FirstOrDefault(p => p.ProductId ==
           productId);
            if (product != null)
            {
                cart.AddItem(product, 1);
            }
            return RedirectToAction("Index", new
            {
                controller = returnUrl.Substring(1)
            });
        }
        public RedirectToRouteResult RemoveFromCart(Cart cart, int productId, string returnUrl)
        {
            Product product = db.Product
            .FirstOrDefault(p => p.ProductId == productId);
            if (product != null)
            {
                cart.RemoveItem(product);
            }
            return RedirectToAction("Index", new { controller = "Cart" });
        }
        private Cart GetCart()
        {
            Cart cart = (Cart)Session["Cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
        return cart;
        }

        public PartialViewResult Summary(Cart cart)
        {
            return PartialView(cart);
        }        public ViewResult Checkout()
        {
            return View(new CheckoutModel());
        }        [HttpPost]
        public ViewResult Checkout(Cart cart, CheckoutModel cm)
        {
            if (cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("CustomError", "Sorry, your cart is empty!");
            }
            if (ModelState.IsValid)
            {
                // order processing logic
                cart.Clear();
                return View("Completed");
            }
            else
            {
            return View(cm);
            }
        }        //public ActionResult Update(FormCollection fc)
        //{
        //    string[] quantities = fc.GetValues("Quantity");
        //    List<CartLine> cart = (List<CartLine>)Session["cart"];
        //    for (int i = 0; i < cart.Count; i++)
        //        cart[i].Quantity = Convert.ToInt32(quantities[i]);
        //    Session["Cart"] = cart;
        //    return View("Cart");
        //}
    }}