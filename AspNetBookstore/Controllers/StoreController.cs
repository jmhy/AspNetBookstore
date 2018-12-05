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

        public ActionResult Browse(string category)
        {
            ViewBag.Message = "Browse Selection";
            var categoryModel = storeDB.Categories.Include("Books").Single(c => c.Name == category);

            return View(categoryModel);
        }

        public ActionResult Details(int id)
        {
            ViewBag.Message = "Details";
            var book = storeDB.Books.Find(id);

            return View(book);
        }
    }
}