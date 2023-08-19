using Microsoft.EntityFrameworkCore;
using Store.Models;
using System.Text.RegularExpressions;

namespace Store.DataAccess.DataContext
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ProductProperties>().HasKey(x => new { x.ProductId, x.PropertiesId });
            modelBuilder.Entity<UserAddress>().HasKey(x => new { x.UserId, x.Country, x.City, x.Street, x.BuildingNo, x.Floor, x.ZipCode });
            modelBuilder.Entity<BuyerProductReview>().HasKey(x => new { x.ProductId, x.BuyerId });
            modelBuilder.Entity<BuyerCart>().HasKey(x => new { x.ProductId, x.BuyerId });


        }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Buyer> Buyer { get; set; }
        public DbSet<BuyerCart> BuyerCart { get; set; }
        public DbSet<BuyerProductReview> BuyerProductReview { get; set; }
        public DbSet<Coupon> Category { get; set; }
        public DbSet<Coupon> Coupon { get; set; }
        public DbSet<Discount> Discount { get; set; }
        public DbSet<Models.Group> Group { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductProperties> ProductProperties { get; set; }
        public DbSet<Promotion> Promotion { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SubCategory> SubCategory { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserAddress> UserAddress { get; set; }
    }
}
