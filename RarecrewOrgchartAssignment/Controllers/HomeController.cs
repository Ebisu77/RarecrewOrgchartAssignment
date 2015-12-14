using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RarecrewOrgchartAssignment.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This is just a testing playground for my web projects";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Feel free to contact me at: ";

            return View();
        }
    }
}