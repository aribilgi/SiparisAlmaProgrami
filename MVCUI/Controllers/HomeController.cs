using System.Web.Mvc;
using BL;

namespace MVCUI.Controllers
{
    public class HomeController : Controller
    {
        ProductManager manager = new ProductManager();
        CategoryManager categoryManager = new CategoryManager();
        public ActionResult Index()
        {
            return View(manager.GetAll());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public PartialViewResult _PartialMenu()
        {
            return PartialView(categoryManager.GetAll());
        }

    }
}