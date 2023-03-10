using ElectroECommerce.Application.IRepositories;
using ElectroECommerce.Domain;

namespace ElectroECommerce.Infrastructure.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {

        }
    }
}
