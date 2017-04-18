using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArcaneTinmen.Controllers
{
    public class PageController : Controller
    {
        // GET: Page
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Business()
        {
            return View();
        }
        public ActionResult Buy()
        {
            return View();
        }
        public ActionResult Download()
        {
            return View();
        }
    }
}