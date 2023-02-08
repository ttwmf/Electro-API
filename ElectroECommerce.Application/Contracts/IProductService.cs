using ElectroECommerce.Domain;

namespace ElectroECommerce.Application.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProductsAsync();

        Task<Product> GetProductByIdAsync(int id);

        Task<Product> UpdateProductAsync(Product product);

        Task<Product> CreateProductAsync(Product product);

        Task DeleteProductAsync(int id);
    }
}
