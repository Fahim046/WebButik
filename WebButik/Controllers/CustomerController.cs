using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace WebButik.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer


        public ActionResult CustomerView()
        {
            return PartialView("_CustomerView");
        }
        
         

         

    }
}