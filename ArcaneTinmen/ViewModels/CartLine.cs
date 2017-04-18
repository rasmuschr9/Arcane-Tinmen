using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ArcaneTinmen.Models;
using ArcaneTinmen.Infrastructure;
using ArcaneTinmen.Controllers;

namespace ArcaneTinmen.ViewModels
{
    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}