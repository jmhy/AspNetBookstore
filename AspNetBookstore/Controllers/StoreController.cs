using AspNetBookstore.Models;
using System.Linq;
using System.Web.Mvc;

namespace AspNetBookstore.Controllers
{
    public class StoreController : Controller
    {
        BookstoreEntities storeDB = new BookstoreEntities();

        public ActionResult Index()
        {
            var categories = storeDB.Categories.ToList();
            return View(categories);
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