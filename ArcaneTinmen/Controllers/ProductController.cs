using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArcaneTinmen.Models;
using ArcaneTinmen.ViewModels;

namespace ArcaneTinmen.Controllers
{
    public class ProductController : Controller
    {

        public int PageSize = 10;
        ArcaneTinmenDBContext db = new ArcaneTinmenDBContext();
        // GET: Product
        public ActionResult Index(string size, int page = 1, string option = "", string search = "")
        {
            IEnumerable<Product> products;
            IEnumerable<Games> games;
            

            if (option == "Name")
            {
                products = db.Product.Where(x => x.Name.Contains(search));
            }
            else
            {
                products = db.Product
                .Where(p => size == null || p.Size.Name == size)
                .OrderBy(p => p.SizeId)
                .Skip((page - 1) * PageSize)
                .Take(PageSize);
            }

            if (size != null)
            {
                games = db.Games
                   .Where(game => game.GameSize
                   .Any(s => s.Size.Name
                    == size));
            }
            else
            {
                games = db.Games.Include("GameSize.Size.Product");
            }

            ProductsListViewModel model = new ProductsListViewModel
            {
                Products = products,
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = size == null ?
                db.Product.Count() :
                db.Product.Where(e => e.Size.Name == size).Count()
                },
                CurrentSize = size,
                Games = games,
                
            };
            return View(model);
        }
    }
}