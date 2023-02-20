using ElectroECommerce.Domain;
using Microsoft.EntityFrameworkCore;

namespace ElectroECommerce.Infrastructure.Repositories
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Specifications> Specifications { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<Promotion> Promotions { get; set; }
        public virtual DbSet<PromotionDetail> PromotionDetails { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<CartDetails> CartsDetails { get; set; }
        public virtual DbSet<Voucher> Vouchers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*            modelBuilder.Entity<OrderDetail>()
                                    .HasOne<Order>(o => o.Order)
                                    .WithMany(od => od.OrderDetails)
                                    .HasForeignKey(o => o.OrderId);*/

            /*            modelBuilder.Entity<OrderDetail>()
                                    .HasOne<Product>(o => o.Product)
                                    .WithMany(p => p.OrderDetails)
                                    .HasForeignKey(o => o.ProductId);*/
            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Supplier>()
                        .HasData(
                        new Supplier { Id = 1, SupplierName = "Asus Việt Nam", Address = "482 Điện Biên Phủ, Q10, HCM", PhoneNumber = "0967823093", Email = "asusvn@gmail.com" }
                );

            modelBuilder.Entity<Specifications>()
                        .HasData(
                        new Specifications { Id = 1, CPU = "Intel Core i9 5600Hz", RAM = "32 GB", Storage = "SSD 512 GB", MonitorSize = "14.1 Inch", VGA = "GTX 650 Ti", Weight = "1.57 Kg" },
                        new Specifications { Id = 2, CPU = "Intel Core i7 3600Hz", RAM = "16 GB", Storage = "SSD 512 GB", MonitorSize = "14.1 Inch", VGA = "", Weight = "1.40 Kg" }
                );

            modelBuilder.Entity<Product>().HasData(
                        new Product
                        {
                            Id = 1,
                            SupplierId = 1,
                            SpecificationsId = 1,
                            ProductCode = "ASUS-G-113",
                            ProductName = "Asus Gaming G113",
                            Description = "Chiến mọi loại game",
                            ImageUrl = "not-exist.pgn",
                            Price = 25000000,
                            QuantityInStock = 20,
                            QuantitySold = 1
                        },
                        new Product
                        {
                            Id = 2,
                            SupplierId = 1,
                            SpecificationsId = 2,
                            ProductCode = "ASUS-Vivo",
                            ProductName = "Asus VP-14",
                            Description = "Laptop văn phòng",
                            ImageUrl = "not-exist.pgn",
                            Price = 20000000,
                            QuantityInStock = 30,
                            QuantitySold = 2
                        }
                );

            modelBuilder.Entity<Customer>().HasData(
                        new Customer { Id = 1, PhoneNumber = "0967823093", Address = "06 Trần Văn Ơn", Email = "hqthai@gmail.com", CustomerName = "HQ Thai", password = "123456", Username = "hqthai@gmail.com" }
                );

            modelBuilder.Entity<Order>().HasData(
                        new Order { Id = 1, CustomerId = 1, ShippingAddres = "06 Trần Văn Ơn", ShippingCost = 0, PaymentMethod = 1, TotalItems = 3, TotalDiscount = 0, TotalPrice = 335000, VoucherCode = "Free-ship" }
                );

            modelBuilder.Entity<OrderDetail>().HasData(
                        new OrderDetail { Id = 1, OrderId = 1, ProductId = 1, Quantity = 1 },
                        new OrderDetail { Id = 2, OrderId = 1, ProductId = 2, Quantity = 2 }
                ); ;
        }



    }
}
