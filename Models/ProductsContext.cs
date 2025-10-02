using Microsoft.EntityFrameworkCore;

namespace ProductAPI.Models
{
    public class ProductsContext : DbContext
    {

         public ProductsContext(DbContextOptions<ProductsContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 1, ProductName = "IPhone 11", Price = 25000, IsActive = true });
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 2, ProductName = "IPhone 12", Price = 27000, IsActive = false });
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 3, ProductName = "IPhone 13", Price = 45000, IsActive = true });
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 4, ProductName = "IPhone 14", Price = 65000, IsActive = false });

        }
       
            public DbSet<Product> Products { get; set; }

    }
}