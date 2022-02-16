using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestViewTextFile.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var texts = System.IO.File.ReadLines(Server.MapPath("~/App_Data/Sample.txt"));
            ViewBag.Data = texts;

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