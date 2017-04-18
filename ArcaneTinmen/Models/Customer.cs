namespace ArcaneTinmen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("customer")]
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Orders = new HashSet<Orders>();
        }

        public int CustomerId { get; set; }

        [StringLength(25)]
        public string Firstname { get; set; }

        [StringLength(25)]
        public string Lastname { get; set; }

        [StringLength(25)]
        public string Adress { get; set; }

        [StringLength(4)]
        public string Zip { get; set; }

        [StringLength(25)]
        public string City { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }

        //Constructor
        public Customer(int customerid, string firstname, string lastname, string adress, string zip, string city)
        {
            CustomerId = customerid;
            Lastname = lastname;
            Adress = adress;
            Zip = zip;
            City = city;
        }
    }
}
