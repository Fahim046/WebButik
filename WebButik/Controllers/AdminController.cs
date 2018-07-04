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
            return PartialView("_AdminView", db.Product.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }  

        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                db.Product.Add(product);
                db.SaveChanges();
                //db.Product.Add(product);
                return RedirectToAction("Index");
            }
            else
            {
                return View(product);
            }

        }
    }
}