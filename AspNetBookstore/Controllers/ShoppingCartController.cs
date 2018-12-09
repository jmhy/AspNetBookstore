﻿using System.Linq;
using System.Web.Mvc;
using AspNetBookstore.Models;
using AspNetBookstore.ViewModels;

namespace AspNetBookstore.Controllers
{
    public class ShoppingCartController : Controller
    {
        AspNetBookstoreContext storeDB = new AspNetBookstoreContext();

        public ActionResult Index()
        {
            var cart = ShoppingCart.GetCart(this.HttpContext);

            var viewModel = new ShoppingCartViewModel
            {
                CartItems = cart.GetCartItems(),
                CartTotal = cart.GetTotal()
            };

            return View(viewModel);
        }

        public ActionResult AddToCart(int id)
        {
            var addedBook = storeDB.Books.Single(book => book.BookId == id);
            
            var cart = ShoppingCart.GetCart(this.HttpContext);

            cart.AddToCart(addedBook);
            
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult RemoveFromCart(int id)
        {
            var cart = ShoppingCart.GetCart(this.HttpContext);
            
            string bookName = storeDB.Carts.Single(item => item.RecordId == id).Book.Title;
            
            int itemCount = cart.RemoveFromCart(id);
            
            var results = new ShoppingCartRemoveViewModel
            {
                Message = Server.HtmlEncode(bookName) + " has been removed from your shopping cart.",
                CartTotal = cart.GetTotal(),
                CartCount = cart.GetCount(),
                ItemCount = itemCount,
                DeleteId = id
            };

            return Json(results);
        }

        [ChildActionOnly]
        public ActionResult CartSummary()
        {
            var cart = ShoppingCart.GetCart(this.HttpContext);

            ViewData["CartCount"] = cart.GetCount();

            return PartialView("CartSummary");
        }
    }
}