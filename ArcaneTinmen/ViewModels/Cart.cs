using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ArcaneTinmen.Models;
using ArcaneTinmen.Infrastructure;
using ArcaneTinmen.Controllers;

namespace ArcaneTinmen.ViewModels
{
    public class Cart
    {

        //fields
        private List<CartLine> lines = new List<CartLine>();

        public decimal TotalPrice
        {
            get
            {
                return lines.Sum(e => e.Product.Price * e.Quantity);
            }
        }

        public List<CartLine> Lines
        {
            get { return lines; }
        }

        //constructor
        public Cart()
        {

        }

        //method
        public void AddItem(Product product, int quantity)
        {
            CartLine item = lines.Where(p => p.Product.Name == product.Name).FirstOrDefault();
            if (item == null)
            {
                lines.Add(new CartLine { Product = product, Quantity = quantity });
            }
            else
            {
                item.Quantity += quantity;
            }
        }


        public void RemoveItem(Product product)
        {
            lines.RemoveAll(i => i.Product.Name == product.Name);
        }
        public void Clear()
        {
            lines.Clear();
        }

    }
}