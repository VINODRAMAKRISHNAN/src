using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test_app_build.Utility;

namespace test_app_build.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TestUtil ut = new TestUtil();
            int k = ut.Calcualte(1, 2);
            int y = 2;
            return View();
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
    }
}