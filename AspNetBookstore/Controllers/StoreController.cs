using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetBookstore.Controllers
{
    public class StoreController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Browse()
        {
            ViewBag.Message = "Browse Selection";

            return View();
        }

        public ActionResult Details()
        {
            ViewBag.Message = "Details";

            return View();
        }
    }
}