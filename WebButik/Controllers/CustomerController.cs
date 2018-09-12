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


        public ActionResult CustomerView()
        {
            return PartialView("_CustomerView");
        }


        [Authorize(Roles = "user")]
        public ActionResult AddCart(Product product)
        {

             User.Identity.GetUserId();
             



            // database.user.find(id)
            // User -> Customer -> Cart -> CartRows -> Product
            return View();

        }

         

    }
}