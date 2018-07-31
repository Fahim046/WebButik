using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebButik.Models;

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
            //return PartialView("_CustomerView");

            return RedirectToAction("_CustomerView");
        }
        
         

         

    }
}