using ElectroECommerce.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Runtime.InteropServices;

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

            // fluent api
            modelBuilder.Entity<Order>()
                        .HasIndex(o => o.OrderCode)
                        .IsUnique();

            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            SeedDataSupplier(modelBuilder);
            SeenDataCustomer(modelBuilder);
            SeenDataSpecifications(modelBuilder);
            SeenDataProduct(modelBuilder);
            SeenDataOrder(modelBuilder);
            SeenDataOrderDetail(modelBuilder);
            SeenDataCart(modelBuilder);
            SeenDataCartDetail(modelBuilder);
            SeenDataReview(modelBuilder);
            SeenDataPromotion(modelBuilder);
            SeenDataPromotionDetail(modelBuilder);
            SeenDataVoucher(modelBuilder);

        }

        private void SeedDataSupplier(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Supplier>()
                .HasData(
                        new Supplier
                        {
                            Id = 1,
                            SupplierName = "Asuss Việt Nam",
                            Address = "482 Điện Biên Phủ, Q10, HCM",
                            PhoneNumber = "123456789",
                            Email = "asusvn@gmail.com"
                        },
                        new Supplier
                        {
                            Id = 2,
                            SupplierName = "MSI Việt Nam",
                            Address = "86 Trương Định, Q1, HCM",
                            PhoneNumber = "123456789",
                            Email = "msivn@gmail.com"
                        },
                        new Supplier
                        {
                            Id = 3,
                            SupplierName = "Apple Việt Nam",
                            Address = "112 Lê Duẩn, Q6, HCM",
                            PhoneNumber = "123456789",
                            Email = "apple@gmail.com"
                        },
                        new Supplier
                        {
                            Id = 4,
                            SupplierName = "Dell Việt Nam",
                            Address = " 116 Thủ Đức, Q7, HCM",
                            PhoneNumber = "123456789",
                            Email = "dellvn@gmail.com"
                        }
                    );
        }

        private void SeenDataCustomer(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasData(
                        new Customer
                        {
                            Id = 1,
                            PhoneNumber = "0123456789",
                            Address = "06 Trần Văn Ơn",
                            Email = "hqthai@gmail.com",
                            CustomerName = "HQ Thai",
                            password = "123456",
                            Username = "hqthai@gmail.com"
                        },
                        new Customer
                        {
                            Id = 2,
                            PhoneNumber = "0123456789",
                            Address = "86 Phú Mỹ",
                            Email = "nvtuan@gmail.com",
                            CustomerName = "NV Tuan",
                            password = "123456",
                            Username = "nvtuan@gmail.com"
                        },
                        new Customer
                        {
                            Id = 3,
                            PhoneNumber = "0123456789",
                            Address = "06 Phú Tân",
                            Email = "hhvan@gmail.com",
                            CustomerName = "HH Van",
                            password = "123456",
                            Username = "hhvan@gmail.com"
                        }
                );
        }

        private void SeenDataSpecifications(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Specifications>()
                .HasData(
                        new Specifications
                        {
                            Id = 1,
                            CPU = "Intel Core i9 5600Hz",
                            RAM = "32 GB",
                            Storage = "SSD 512 GB",
                            MonitorSize = "14.1 Inch",
                            VGA = "GTX 650 Ti",
                            Weight = "1.57 Kg"
                        },
                        new Specifications
                        {
                            Id = 2,
                            CPU = "Intel Core i3 - 10100F",
                            RAM = "64 GB",
                            Storage = "SSD 512 GB",
                            MonitorSize = "14.1 Inch",
                            VGA = "GTX 650 Ti",
                            Weight = "1.35 Kg"
                        },
                        new Specifications
                        {
                            Id = 3,
                            CPU = "Intel Core i9 - 12900K",
                            RAM = "64 GB",
                            Storage = "SSD 128 GB",
                            MonitorSize = "14.1 Inch",
                            VGA = "GTX 1050Ti",
                            Weight = "1.20 Kg"
                        },
                        new Specifications
                        {
                            Id = 4,
                            CPU = "Intel Core i7 - 11700F",
                            RAM = "128 GB",
                            Storage = "SSD 128 GB",
                            MonitorSize = "14.1 Inch",
                            VGA = "GTX 1050Ti",
                            Weight = "1.20 Kg"
                        },
                        new Specifications
                        {
                            Id = 5,
                            CPU = "Intel Core i5 11400F",
                            RAM = "128 GB",
                            Storage = "SSD 128 GB",
                            MonitorSize = "14.1 Inch",
                            VGA = "GTX 1050 Ti",
                            Weight = "1.78 Kg"
                        }
                );
        }

        private void SeenDataProduct(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasData(
                       new Product
                       {
                           Id = 1,
                           SupplierId = 1,
                           SpecificationsId = 1,
                           ProductCode = "ASUS-G-113",
                           ProductName = "Asus Gaming G113",
                           Description = "Khoác lên mình lớn màu xám cá tính với mặt A tinh xảo, " +
                           "bản lề gập mở đến 180 độ mang đến khả năng làm việc thuận tiện hơn, " +
                           "tăng khả năng tương tác và trình chiếu đến với người đối diện. Có dung " +
                           "lượng pin lớn, sử dụng nhiều giờ mà không lo cuộc chơi bị gián đoạn. Hệ" +
                           " điều hành windows 11 sẽ giúp máy chạy ổn định, không bị giật lag, hình" +
                           " ảnh hiển thị sắc nét, nhờ card đồ họa, làm khung hình trở nên rõ ràng hơn.",
                           ImageUrl = "asus_g_113.png",
                           Price = 25000000,
                           QuantityInStock = 20,
                           QuantitySold = 1
                       },
                       new Product
                       {
                           Id = 2,
                           SupplierId = 1,
                           SpecificationsId = 2,
                           ProductCode = "ASUS-V-X415",
                           ProductName = "ASUS VivoBook X415",
                           Description = "Kích thước 14.0 inches với độ phân giải Full HD, màn hình " +
                           "chống chói mang lại chất lượng hiển thị rõ nét, mượt mà. Cổng kết nối đa dạng" +
                           " - Thuận tiện cho người dùng. Năng lượng bất tận cả ngày với viên pin " +
                           "37WHrs, 2S1P, 2 - cell Li - ion.Máy đi kèm Windows 11 bản quyền.Với thiết" +
                           " kế nhỏ gọn, hiệu năng mượt mà, máy sẽ đáp ứng mọi nhu cầu sử dụng cơ bản " +
                           "hàng ngày của bạn nhanh chóng và hiệu quả.",
                           ImageUrl = "asus_v_x415.png",
                           Price = 22000000,
                           QuantityInStock = 10,
                           QuantitySold = 0
                       },
                       new Product
                       {
                           Id = 3,
                           SupplierId = 1,
                           SpecificationsId = 3,
                           ProductCode = "ASUS-F-1100",
                           ProductName = "ASUS Flip BR1100",
                           Description = "Thiết kế nhỏ gọn, năng động với màu xám hiện đại trang bị" +
                           " đầy đủ các cổng kết nối cơ bản: USB Type - A,... dễ dàng kết nối với các" +
                           " thiết bị ngoại vi chỉ trong chớp mắt. Máy đạt độ bền đáp ứng tiêu chuẩn quân" +
                           " sự MIL - STD 810H với nhiều bài kiểm tra ngoài trời nghiêm ngặt như độ cao," +
                           " nhiệt độ,độ ẩm, áp suất,Sự kết hợp hài hòa giữa ngoại hình năng động và hiện " +
                           "đại, cùng hiệu năng vượt trội đã tạo nên laptop ASUS Flip BR1100 - sản phẩm " +
                           "laptop đơn giản mà sang trọng sẵn sàng phục vụ người dùng công nghệ chuyên nghiệp", 
                           ImageUrl = "asus_f_1100.png", 
                           Price = 15000000, 
                           QuantityInStock = 10,
                           QuantitySold = 1
                       },
                       new Product
                       {
                           Id = 4,
                           SupplierId = 1,
                           SpecificationsId = 1,
                           ProductCode = "ASUS-Z-14",
                           ProductName = "Asus Zenbook 14",
                           Description = "Thiết kế siêu mỏng nhẹ sang trọngcảm ứng đa điểm, xoay gập 360 độ với" +
                           " độ phân giải Full HD trên tấm nền OLED mang lại chất lượng hiển thị rõ nét, mượt mà." +
                           " Tích hợp webcam HD cho phép đàm thoại thông qua video thoải mái. Loa SonicMaster audio" +
                           " - mang lại trải nghiệm giải trí chân thật. Năng lượng bất tận cả ngày với viên pin 4 -" +
                           " cell, 67Wh. Máy đi kèm Windows 10 bản quyền.", 
                           ImageUrl = "asus_z_14.png", 
                           Price = 20000000, 
                           QuantityInStock = 10, 
                           QuantitySold = 2
                       },
                       new Product
                       {
                           Id = 5,
                           SupplierId = 2,
                           SpecificationsId = 2,
                           ProductCode = "MSI-M-A5",
                           ProductName = "MSI Modern A5",
                           Description = "Hiệu năng hàng đầu, chiến tốt cả các tựa game Esport như LOL, Fifađộ phân " +
                           "giải Full HD mang lại chất lượng hiển thị sắc nét. Siêu bền bỉ - Độ bền chuẩn quân đội MIL " +
                           "- STD - 810G. Máy đi kèm Windows 11 bản quyền.là sản phẩm thuộc thương hiệu MSI, do đó laptop" +
                           " sở hữu nhiều ưu điểm của thương hiệu laptop chất lượng này như thiết kế nhỏ gọn, hiệu năng vượt trội.", 
                           ImageUrl = "msi_m_a5.png", 
                           Price = 20000000, 
                           QuantityInStock = 20,
                           QuantitySold = 1
                       },
                       new Product
                       {
                           Id = 6,
                           SupplierId = 2,
                           SpecificationsId = 3,
                           ProductCode = "MSI-G-GF6",
                           ProductName = "MSi Gaming GF6",
                           Description = "Bộ vi xử lý hiệu năng cao, ổn định và mạnh mẽ Card đồ họa mạnh mẽ Nvidia Geforce " +
                           "GTX 1650 MaxQ, GDDR6 4GB Công nghệ âm thanh rõ ràng đúng chất NVIDIA TuringTM cho trải nghiệm hoàn" +
                           " hảo Viên pin dung lượng lớn đến 52Whr hoạt động trong nhiều giờ", 
                           ImageUrl = "msi_g_gf6.png",
                           Price = 25000000, 
                           QuantityInStock = 10, 
                           QuantitySold = 0
                       },
                       new Product
                       {
                           Id = 7,
                           SupplierId = 2,
                           SpecificationsId = 4,
                           ProductCode = "MSI-G-GF63",
                           ProductName = "MSI Gaming GF63",
                           Description = "Bộ vi xử lý hiệu năng cao, ổn định và mạnh mẽ Card đồ họa mạnh mẽ Nvidia Geforce " +
                           "GTX 1650 MaxQ,GDDR6 4GB Công nghệ âm thanh rõ ràng đúng chất NVIDIA TuringTM cho trải nghiệm hoàn" +
                           " hảo. Viên pin dung lượng lớn đến 52Whr hoạt động trong nhiều giờ Laptop MSI Gaming GF63 tiếp tục sử" +
                           " hữu thiết kế quen thuộc của dòng MSI Gaming. Không chỉ nổi bật về thiết kế mà GF63 còn gây ấn tượng" +
                           " bởi hiệu năng ổn định,mạnh mẽ.", 
                           ImageUrl = "msi_g_gf63.png", 
                           Price = 15000000, 
                           QuantityInStock = 10, 
                           QuantitySold = 1
                       },
                       new Product
                       {
                           Id = 8,
                           SupplierId = 2,
                           SpecificationsId = 5,
                           ProductCode = "MSI-M-14",
                           ProductName = "MSI Modern 14",
                           Description = "Xử lý tốt các ứng dụng như word, exel, PTS hay giải trí nhẹ nhàngThiết kế thanh lịch - " +
                           "khum nhôm siêu mỏng nhẹ thuận lợi mang theo khi đi học,làm việc. Màn hình hiển thị sống động - độ phân giải" +
                           " full HD, tần số quét 60Hz. Làm việc hiệu quả hơn - bàn phím được trang bị đèn Led", 
                           ImageUrl = "msi_m_14.png", 
                           Price = 25000000, 
                           QuantityInStock = 20, 
                           QuantitySold = 2
                       },
                       new Product
                       {
                           Id = 9,
                           SupplierId = 3,
                           SpecificationsId = 5,
                           ProductCode = "MacBook-A-M2",
                           ProductName = "MacBook Air M2",
                           Description = "Phù hợp cho lập trình viên, thiết kế đồ họa 2D, dân văn phòng. Hiệu năng vượt trội - " +
                           "Cân mọi tác vụ từ word, exel đến chỉnh sửa ảnh trên các phần mềm như AI, PTS Chất lượng hình ảnh sắc nét " +
                           "- Màn hình Retina cao cấp cùng công nghệ TrueTone cân bằng màu sắc", 
                           ImageUrl = "macbook_a_m2.png", 
                           Price = 20000000, 
                           QuantityInStock = 10, 
                           QuantitySold = 1
                       },
                       new Product
                       {
                           Id = 10,
                           SupplierId = 3,
                           SpecificationsId = 3,
                           ProductCode = "MacBook-A-M1",
                           ProductName = "MacBook Air M1",
                           Description = "Kích thước 14.0 inches với độ phân giải Full HD, màn hình chống chói mang lại chất lượng" +
                           " hiển thị rõ nét, mượt mà. Cổng kết nối đa dạng - Thuận tiện cho người dùng.Năng lượng bất tận cả ngày" +
                           " với viên pin 37WHrs, 2S1P, 2 - cell Li - ion.Máy đi kèm Windows 11 bản quyền.Với thiết kế nhỏ gọn, hiệu" +
                           " năng mượt mà,máy sẽ đáp ứng mọi nhu cầu sử dụng cơ bản hàng ngày của bạn nhanh chóng và hiệu quả.", 
                           ImageUrl = "macbook_a_m1.png", 
                           Price = 15000000, 
                           QuantityInStock = 10,
                           QuantitySold = 1
                       },
                       new Product
                       {
                           Id = 11,
                           SupplierId = 3,
                           SpecificationsId = 2,
                           ProductCode = "MacBook-P-13",
                           ProductName = "MacBook Pro 13",
                           Description = "Apple MacBook Pro 13 mang đến một thiết kế màn hình vượt trội, góp phần hiển thị chất lượng " +
                           "hình ảnh đến mức đáng kinh ngạc. Đồng thời, những dòng Macbook Pro 2016 mang đến một thiết kế tinh tế vượt " +
                           "trội, tạo nên một điểm nhấn vô cùng nổi bật cho người dùng.Hãy cùng khám phá thêm mẫu Apple MacBook Pro 13 " +
                           "với hiệu năng vượt trội, giúp bạn dễ dàng đáp ứng được nhiều công việc khác nhau", 
                           ImageUrl = "macbook_p_13.png", 
                           Price = 22000000, 
                           QuantityInStock = 20, 
                           QuantitySold = 0
                       },
                       new Product
                       {
                           Id = 12,
                           SupplierId = 3,
                           SpecificationsId = 1,
                           ProductCode = "MacBook-P-14",
                           ProductName = "Macbook Pro 14",
                           Description = "Phù hợp cho lập trình viên, thiết kế đồ họa 2D, dân văn phòng. Hiệu năng vượt trội - Cân mọi tác " +
                           "vụ từ word, exel đến chỉnh sửa ảnh trên các phần mềm như AI, PTS Chất lượng hình ảnh sắc nét - Màn hình Retina" +
                           " cao cấp cùng công nghệ TrueTone cân bằng màu sắc", 
                           ImageUrl = "macbook_p_14.png", 
                           Price = 22000000, 
                           QuantityInStock = 10,
                           QuantitySold = 2
                       },
                       new Product
                       {
                           Id = 13,
                           SupplierId = 4,
                           SpecificationsId = 4,
                           ProductCode = "Dell-L-3520",
                           ProductName = "Dell Latitude 3520",
                           Description = "Thiết kế mỏng nhẹ, vỏ ngoài cứng cáp với các cạnh được bo tròn mềm mại. Card đồ họa Intel UHD Graphics " +
                           "đáp ứng đầy đủ nhu cầu lướt web, xem phim, thiết kế cơ bản trên Photoshop, Canva,...Dọc 2 bên máy là các cổng kết nối" +
                           " phổ biến như: USB Type - A, USB Type - C, HDMI, ... hỗ trợ người dùng chia sẻ thông tin hay truyền tải dữ liệu nhanh" +
                           " chóng. Hỗ trợ kết nối Bluetooth và Wi - Fi 6 AX201 2x2 802.11ax mang đến tốc độ truyền tải cao,đảm bảo đường truyền mạng" +
                           " luôn được ổn định.", 
                           ImageUrl = "dell_l_3520.png", 
                           Price = 15000000, 
                           QuantityInStock = 10, 
                           QuantitySold = 0
                       },
                       new Product
                       {
                           Id = 14,
                           SupplierId = 4,
                           SpecificationsId = 5,
                           ProductCode = "Dell-V-3400",
                           ProductName = "Dell Vostro 3400",
                           Description = "AMD Ryzen 5 - 3500U cùng card AMD Radeon Vega 8 Graphics - Làm việc văn phòng hay giải trí nhẹ nhàng Công" +
                           " nghệ chống chói Anti Glare - Làm việc không lo bị mỏi mắt. Chất lượng hiển thị đỉnh cao - Màn hình 14.0 inches, Full HD. " +
                           "Năng lượng bất tận cả ngày với viên pin 3 - cell Li - ion, 42 Wh .Loa Realtek High Definition audio - mang lại trải nghiệm" +
                           " giải trí chân thật,sống động.Máy đi kèm Windows 11 bản quyền.", 
                           ImageUrl = "dell_v_3400.png", 
                           Price = 22000000, 
                           QuantityInStock = 20, 
                           QuantitySold = 1
                       },
                       new Product
                       {
                           Id = 15,
                           SupplierId = 4,
                           SpecificationsId = 5,
                           ProductCode = "Dell-I-3511",
                           ProductName = "Dell Inspiron 3511",
                           Description = "AMD Ryzen 5 - 3500U cùng card AMD Radeon Vega 8 Graphics - Làm việc văn phòng hay giải trí nhẹ nhàng. Công nghệ " +
                           "chống chói Anti Glare - Làm việc không lo bị mỏi mắt. Chất lượng hiển thị đỉnh cao - Màn hình 14.0 inches, Full HD. Đa dạng các cổng" +
                           " kết nối: jack cắm audio, cổng HDMI 1.4, cổng USB C, ...dễ truyền hoặc xuất dữ liệu với nhiều thiết bị khác nhau. Tích hợp webcam " +
                           "720p HD cho phép đàm thoại thông qua video thoải mái. Năng lượng bất tận cả ngày với viên pin 3 Cell,41 Wh.", 
                           ImageUrl = "dell_i_3511.png", 
                           Price = 20000000, 
                           QuantityInStock = 20,
                           QuantitySold = 2
                       }
               );
        }

        private void SeenDataOrder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasData(
                        new Order
                        {
                            Id = 1,
                            OrderCode = "ABC-123",
                            CustomerId = 1,
                            ShippingAddress = "06 Trần Văn Ơn",
                            ShippingCost = 0,
                            PaymentMethod = 1,
                            TotalItems = 3,
                            TotalDiscount = 0,
                            TotalPrice = 69000000,
                            VoucherCode = "Free-ship"
                        },
                        new Order
                        {
                            Id = 2,
                            OrderCode = "ABC-456",
                            CustomerId = 2,
                            ShippingAddress = "86 Phú Mỹ",
                            ShippingCost = 0,
                            PaymentMethod = 1,
                            TotalItems = 3,
                            TotalDiscount = 0,
                            TotalPrice = 45000000,
                            VoucherCode = "Free-ship"
                        },
                        new Order
                        {
                            Id = 3,
                            OrderCode = "ABC-789",
                            CustomerId = 3,
                            ShippingAddress = "06 Phú Tân",
                            ShippingCost = 0,
                            PaymentMethod = 1,
                            TotalItems = 2,
                            TotalDiscount = 0,
                            TotalPrice = 40000000,
                            VoucherCode = "Free-ship"
                        }
                );
        }

        private void SeenDataOrderDetail(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetail>()
                .HasData(
                        new OrderDetail
                        {
                            Id = 1,
                            OrderId = 1,
                            ProductId = 1,
                            Quantity = 1

                        },
                        new OrderDetail
                        {
                            Id = 2,
                            OrderId = 1,
                            ProductId = 2,
                            Quantity = 2

                        },
                        new OrderDetail
                        {
                            Id = 3,
                            OrderId = 2,
                            ProductId = 3,
                            Quantity = 3

                        },
                        new OrderDetail
                        {
                            Id = 4,
                            OrderId = 3,
                            ProductId = 1,
                            Quantity = 1

                        },
                        new OrderDetail
                        {
                            Id = 5,
                            OrderId = 3,
                            ProductId = 3,
                            Quantity = 1

                        }
                );
        }
        
        private void SeenDataPromotion(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Promotion>()
                .HasData(
                    new Promotion
                    {
                        Id = 1,
                        PromotionName = "Chào mừng năm học mới",
                        Description = "Nhân dịp chào mừng năm học mới, Electro áp dụng chương trình khuyến mãi khủng Giảm giá 20 % cho mỗi sản phẩm",
                        ImageUrl = "chao_mung_nam_hoc_moi.png",
                        StartAt = new DateTime(2022-08-20),
                        EndAt = new DateTime(2022-08-30)
                    },
                    new Promotion
                    {
                        Id = 2,
                        PromotionName = "Mừng năm mới 2023",
                        Description = "Electro hiện đang có chương trình Mừng ngày năm mới đồng loạt giảm sốc hàng nghìn sản phẩm khi đặt mua Online, mức giảm lên đến 49%. Bạn có thể tham gia săn flashsale trong 3h và mua sản phẩm giá sốc. ",
                        ImageUrl = "mung_nam_moi_2023.png",
                        StartAt = new DateTime(2023-01-01),
                        EndAt = new DateTime(2023-03-01)
                    },
                    new Promotion
                    {
                        Id = 3,
                        PromotionName = "Mừng giải phóng miền nam 30/04",
                        Description = "Kỷ niệm ngày giải phóng miền nam, Elctro có chương trình Hot sale giảm đến 50%++ với hàng ngàn sản phẩm công nghệ bán chạy.",
                        ImageUrl = "mung_ngay_giai_phong_mien_nam_30/04.png",
                        StartAt = new DateTime(2023-04-30),
                        EndAt = new DateTime(2023-05-01)
                    }
                );
                
        }

        private void SeenDataPromotionDetail(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PromotionDetail>()
                .HasData(
                    new PromotionDetail
                    {
                        Id = 1,
                        PromotionId = 1,
                        ProductId = 1,
                        DiscountPrice = 5000000,
                        DiscountPercent = 20,
                        DiscountType = 0
                    },
                    new PromotionDetail
                    {
                        Id = 2,
                        PromotionId = 2,
                        ProductId = 4,
                        DiscountPrice = 4000000,
                        DiscountPercent = 20,
                        DiscountType = 0
                    },
                    new PromotionDetail
                    {
                        Id = 3,
                        PromotionId = 3,
                        ProductId = 11,
                        DiscountPrice = 2200000,
                        DiscountPercent = 10,
                        DiscountType = 0
                    },
                    new PromotionDetail
                    {
                        Id = 4,
                        PromotionId = 1,
                        ProductId = 10,
                        DiscountPrice = 750000,
                        DiscountPercent = 5,
                        DiscountType = 0
                    }
                );

        }

        private void SeenDataVoucher(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Voucher>()
                .HasData(
                    new Voucher
                    {
                        Id = 1,
                        VoucherName = "Khai giảng năm học",
                        VoucherCode = "KG-123",
                        ImageUrl = "khai_giang.png",
                        DiscountType = 1,
                        DiscountPercent = 100000,
                        DiscountPrice = 2
                    },
                    new Voucher
                    {
                        Id = 2,
                        VoucherName = "Chi ân khách hàng",
                        VoucherCode = "CNKH-123",
                        ImageUrl = "chi_an_khach_hang.png",
                        DiscountType = 1,
                        DiscountPercent = 100000,
                        DiscountPrice = 2
                    },
                    new Voucher
                    {
                        Id = 3,
                        VoucherName = "Qùa Noel bất ngờ",
                        VoucherCode = "QNBN-456",
                        ImageUrl = "qua_noel_bat_ngo.png",
                        DiscountType =1,
                        DiscountPercent = 100000,
                        DiscountPrice = 2
                    },
                    new Voucher
                    {
                        Id = 4,
                        VoucherName = "Mừng xuân",
                        VoucherCode = "MX-789",
                        ImageUrl = "mung_xuan.png",
                        DiscountType = 0,
                        DiscountPercent = 100000,
                        DiscountPrice = 2
                    }
                );

        }

        private void SeenDataCart(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cart>()
                .HasData(
                    new Cart
                    {
                        Id = 1,
                        CustomerId = 1,
                        TotalItems = 3,
                        TotalPrice = 69000000
                    },
                    new Cart
                    {
                        Id = 2,
                        CustomerId = 2,
                        TotalItems = 3,
                        TotalPrice = 45000000
                    },
                    new Cart
                    {
                        Id = 3,
                        CustomerId = 3,
                        TotalItems = 2,
                        TotalPrice = 40000000
                    }
                );

        }

        private void SeenDataCartDetail(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CartDetails>()
                .HasData(
                    new CartDetails
                    {
                        Id = 1,
                        ProductId = 1,
                        CartId = 1,
                        Quantity = 1,
                        TotalPrice = 25000000

                    },
                    new CartDetails
                    {
                        Id = 2,
                        ProductId = 2,
                        CartId = 1,
                        Quantity = 2,
                        TotalPrice = 44000000

                    },
                    new CartDetails
                    {
                        Id = 3,
                        ProductId = 3,
                        CartId = 2,
                        Quantity = 3,
                        TotalPrice = 45000000

                    },
                    new CartDetails
                    {
                        Id = 4,
                        ProductId = 1,
                        CartId = 3,
                        Quantity = 1,
                        TotalPrice = 25000000

                    },
                    new CartDetails
                    {

                        Id= 5,
                        ProductId = 3,
                        CartId = 3,
                        Quantity = 1,
                        TotalPrice = 15000000

                    }
                );

        }

        private void SeenDataReview(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Review>()
                .HasData(
                    new Review
                    {
                        Id = 1,
                        ProductId = 1,
                        CustomerId = 1,
                        Title = "Good",
                        Comment = "Sản phẩm này rất tốt",
                        RatingPoint = 5

                    },
                    new Review
                    {
                        Id = 2,
                        ProductId = 2,
                        CustomerId = 1,
                        Title = "Good",
                        Comment = "Máy này mạnh lắm mọi người. Tui recoment mọi người nên xài máy này nha",
                        RatingPoint = 5

                    },
                    new Review
                    {
                        Id = 3,
                        ProductId = 3,
                        CustomerId = 1,
                        Title = "Bad",
                        Comment = "Giao hàng chậm quá à!",
                        RatingPoint = 3

                    },
                    new Review
                    {   
                        Id = 4,
                        ProductId = 4,
                        CustomerId = 1,
                        Title = "Good",
                        Comment = "Máy này dân văn phòng xài thì hết xẩy",
                        RatingPoint = 5

                    },
                    new Review
                    {
                        Id = 5,
                        ProductId = 5,
                        CustomerId = 2,
                        Title = "Good",
                        Comment = "Máy này dđẹp mà hiệu năng cao cực. Tui sử dụng để làm các tác vụ Office rất mượt nha",
                        RatingPoint = 5

                    }
                );

        }

    }
}
