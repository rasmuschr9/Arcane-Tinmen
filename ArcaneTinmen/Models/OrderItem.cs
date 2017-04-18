namespace ArcaneTinmen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("orderitem")]
    public partial class OrderItem
    {
        public int OrderItemId { get; set; }

        public int Quantity { get; set; }

        public decimal TotalPrice { get; set; }

        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public virtual Orders Orders { get; set; }

        public virtual Product Product { get; set; }
        
        //Constructors
        public OrderItem(int orderitemid, int quantity, decimal totalprice, int orderid, int productid)
        {
            OrderItemId = orderitemid;
            Quantity = quantity;
            TotalPrice = totalprice;
            OrderId = orderid;
            ProductId = productid;
        }
    }
}
