using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebButik.Models;
using Microsoft.AspNet.Identity;
using System.Net;

namespace WebButik.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public static ButikDB db = new ButikDB();
        ApplicationDbContext userDB = new ApplicationDbContext();
        ButikDB butikDB = new ButikDB();

        public ActionResult CustomerView()
        {
            return PartialView("_CustomerView");
        }


        [Authorize(Roles = "User")]
        public ActionResult AddCart(int id)
        {

            Product product = butikDB.Product.Find(id);

            if (product != null)
            {

                string userId = User.Identity.GetUserId();

                int customerID = userDB.Users.Find(userId).CustomerID;

                Cart cart = butikDB.Customer.Include("Cart").Include("Cart.Cartrows").SingleOrDefault(c => c.CustomerId == customerID).Cart;

                cart.Cartrows.Add(new CartRow
                {
                    Count = 1,  
                    Product = product   
                });

                int sum = cart.Cartrows.Sum(row => row.Count);

                if (Session["cartItems"] == null)
                    Session.Add("cartItems", 0);

                Session["cartItems"] = sum;

                butikDB.SaveChanges();
                return RedirectToAction("MenProduct", "Admin");
            }
            

            // database.user.find(id)
            // User -> Customer -> Cart -> CartRows -> Product
            //
            
            return View();  // TODO!!!!!!!!

        }



    }
}