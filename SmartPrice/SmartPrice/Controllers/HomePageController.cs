using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartPrice.Controllers
{
    public class HomePageController : Controller
    {
        // GET: HomePage
        public ActionResult Index()
        {
            return View("HomePage");
        }

        public ActionResult About()
        {
            ViewBag.Message = "We help you to compare any product to decide the best offer available";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact us for more information";

            return View();
        }
    }
}