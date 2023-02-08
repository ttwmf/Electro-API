using ElectroECommerce.Application.IRepositories;
using ElectroECommerce.Domain;
using Microsoft.EntityFrameworkCore;

namespace ElectroECommerce.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _appDbContext;
        public ProductRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _appDbContext.Products.ToListAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _appDbContext.Products.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Product> CreateProductAsync(Product product)
        {
            var result = await _appDbContext.Products.AddAsync(product);
            await _appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Product> UpdateProductAsync(Product product)
        {
            var result = await _appDbContext.Products.FirstOrDefaultAsync(p => p.Id == product.Id);

            if (result != null)
            {
                result.ProductName = product.ProductName;
                await _appDbContext.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task DeleteProductAsync(int id)
        {
            var result = await _appDbContext.Products.FirstOrDefaultAsync(p => p.Id == id);

            if (result != null)
            {
                _appDbContext.Products.Remove(result);
                await _appDbContext.SaveChangesAsync();
            }
        }
    }
}
