using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MvcMovie.Controllers
{
    public class TestController : Controller
    {
     
       

        public ActionResult Index()
        {
            NorthwindEntities entities = new NorthwindEntities();
            return View(entities.SearchCustomers(""));
        }


        [HttpPost]
        public ActionResult Index(string customerName)
        {
            NorthwindEntities entities = new NorthwindEntities();
            return View(entities.SearchCustomers(customerName));
        }
    }
}