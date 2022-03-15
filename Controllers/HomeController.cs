using My_first_Mvc_Program.Models;
using My_first_Mvc_Program.My_DAta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace My_first_Mvc_Program.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            empEntities obj = new empEntities();
            var res = obj.Table_Emp.ToList();
            return View(res);
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