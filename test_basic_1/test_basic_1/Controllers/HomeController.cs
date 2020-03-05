using System;

using System.Web.Mvc;

namespace test_basic_1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.TEXT = "Hello World";
            int var1 = 5;int var2 = 5;
            ViewBag.TEXT1 = var1*var2;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

      

    }
}