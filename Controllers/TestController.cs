using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSocks.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome(string action, string name, int ID = 1)
        {
            ViewBag.Message = HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID + ", action: " + action);
            ViewBag.Title = "Title Test";

            return View();
        }
    }
}