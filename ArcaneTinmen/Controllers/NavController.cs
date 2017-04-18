using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArcaneTinmen.Infrastructure;
using ArcaneTinmen.Models;

namespace ArcaneTinmen.Controllers
{
    public class NavController : Controller
    {
        ArcaneTinmenDBContext db = new ArcaneTinmenDBContext();
        public PartialViewResult Menu(string size = null)
        {
            ViewBag.SelectedSize = size;

            IEnumerable<string> sizes = db.Product
            .Select(x => x.Size.Name)
            .Distinct()
            .OrderBy(x => x);
            return PartialView(sizes);
        }
    }
}