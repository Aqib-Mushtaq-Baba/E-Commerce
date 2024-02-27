using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Data.Models
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Brand> Brand { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }        
        public DbSet<ProductSubCategory> ProductSubCategory { get; set; }
        public DbSet<Rating> Rating { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Checkout> Checkout { get; set; }
        public DbSet<Sale> Sale { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Image> Image { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
