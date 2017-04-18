using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ArcaneTinmen.Models;

namespace ArcaneTinmen.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentSize { get; set; }
        public IEnumerable<Games> Games { get; set; }
        public IEnumerable<Size> Sizes { get; set; }
    }
}
