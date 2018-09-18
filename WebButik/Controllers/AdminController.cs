using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebButik.Models;

namespace WebButik.Controllers
{
    public class AdminController : Controller
    {
        public static ButikDB db = new ButikDB();

        // GET: Admin
        public ActionResult AdminView()
        {
            //return PartialView("_AdminView", db.Product.ToList());
            return PartialView("_AdminView");
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult Create() // By clicking Create, first we come here and return to the _create page where we post the product
        {
            return PartialView("_create");
        }  

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                db.Product.Add(product);
                db.SaveChanges();

                return PartialView("_AdminView");

               // return PartialView("_productList", db.Product.ToList());
               //  return RedirectToAction("Index");

            }
            else
            {
                return PartialView("_create");
                //return View(product);
            }

        }
        [Authorize(Roles = "Admin")]


        public ActionResult ProductList()
        {
             return PartialView("_productList", db.Product.ToList());

            // return View("ProductList", db.Product.ToList());
        }


        public ActionResult MenProduct()
        {

           if(User.IsInRole("User"))
            {
                //return PartialView("_menProduct", db.Product.ToList());
            }
                      
                return View("MenProduct", db.Product.ToList());

        }

    }
}