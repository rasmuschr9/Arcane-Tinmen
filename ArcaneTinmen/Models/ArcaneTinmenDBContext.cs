namespace ArcaneTinmen.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ArcaneTinmenDBContext : DbContext
    {
        public ArcaneTinmenDBContext()
            : base("name=ArcaneTinmen")
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Games> Games { get; set; }
        public virtual DbSet<GameSize> GameSize { get; set; }
        public virtual DbSet<OrderItem> OrderItem { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Size> Size { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.Firstname)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Lastname)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Adress)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Zip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Games>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<OrderItem>()
                .Property(e => e.TotalPrice)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Orders>()
                .Property(e => e.TotalPrice)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Product>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Price)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Product>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Specs)
                .IsUnicode(false);

            modelBuilder.Entity<Size>()
                .Property(e => e.Name)
                .IsUnicode(false);

            Database.SetInitializer<ArcaneTinmenDBContext>(null);
        }

    }
}
