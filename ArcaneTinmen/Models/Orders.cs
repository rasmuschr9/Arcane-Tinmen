namespace ArcaneTinmen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Orders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Orders()
        {
            OrderItem = new HashSet<OrderItem>();
        }

        [Key]
        public int OrderId { get; set; }

        [Column(TypeName = "date")]
        public DateTime OrderDate { get; set; }

        public decimal TotalPrice { get; set; }

        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItem { get; set; }

        //Constructors
        public Orders(int orderid, DateTime orderdate, decimal totalprice, int customerid)
        {
            OrderId = orderid;
            OrderDate = orderdate;
            TotalPrice = totalprice;
            CustomerId = customerid;
        }
    }
}
