using ElectroECommerce.Application.Contracts;
using ElectroECommerce.Application.IRepositories;
using ElectroECommerce.Domain;

namespace ElectroECommerce.Application.Implimentations
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        /// <summary>
        /// Get all product asynchronously
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _productRepository.GetProductsAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _productRepository.GetProductByIdAsync(id);
        }

        public async Task<Product> UpdateProductAsync(Product product)
        {
            bool isValidInfo = ValidateProduct(product);
            if (!isValidInfo)
            {
                return null;
            }
            return await _productRepository.UpdateProductAsync(product);
        }

        public async Task<Product> CreateProductAsync(Product product)
        {
            bool isValidInfo = ValidateProduct(product);
            if (!isValidInfo)
            {
                return null;
            }
            return await _productRepository.CreateProductAsync(product);
        }

        public async Task DeleteProductAsync(int id)
        {
            await _productRepository.DeleteProductAsync(id);
        }


        #region private
        private bool ValidateProduct(Product product)
        {
            return true;
        }

        #endregion private
    }
}
