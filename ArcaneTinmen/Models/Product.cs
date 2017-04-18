namespace ArcaneTinmen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            OrderItem = new HashSet<OrderItem>();
        }

        public int ProductId { get; set; }

        [StringLength(25)]
        public string Name { get; set; }

        public decimal Price { get; set; }

        [StringLength(25)]
        public string Image { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }

        [Column(TypeName = "text")]
        public string Specs { get; set; }

        public int SizeId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItem { get; set; }

        public virtual Size Size { get; set; }
        
        //Constructor
        public Product(int productid, decimal price, string image, string description, string specs, int sizeid)
        {
            ProductId = productid;
            Price = price;
            Image = image;
            Description = description;
            Specs = specs;
            SizeId = sizeid;
        }
    }
}
