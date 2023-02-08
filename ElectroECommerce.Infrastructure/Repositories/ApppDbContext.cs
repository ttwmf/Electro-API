using ElectroECommerce.Domain;
using Microsoft.EntityFrameworkCore;

namespace ElectroECommerce.Infrastructure.Repositories
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
