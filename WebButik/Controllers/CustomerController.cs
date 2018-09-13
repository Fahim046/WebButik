using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebButik.Models;
using Microsoft.AspNet.Identity;
namespace WebButik.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
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
                    //Amount = 1,
                    Product = product
                });

                butikDB.SaveChanges();
            }


            // database.user.find(id)
            // User -> Customer -> Cart -> CartRows -> Product


            return View();  // TODO!!!!!!!!

        }



    }
}