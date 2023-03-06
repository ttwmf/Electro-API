using ElectroECommerce.Application.Contracts;
using ElectroECommerce.Application.IRepositories;
using ElectroECommerce.Domain;

namespace ElectroECommerce.Application.Implimentations
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly ICurrentUserService _currentUserService;
        public ProductService(IProductRepository productRepository, ICurrentUserService currentUserService)
        {
            _productRepository = productRepository;
            _currentUserService = currentUserService;
        }

        /// <summary>
        /// Get all product asynchronously
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            var userName = _currentUserService.UserName;

            return await _productRepository.GetAllAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _productRepository.GetAsync(id);
        }

        public async Task<Product> UpdateProductAsync(Product product)
        {
            bool isValidInfo = ValidateProduct(product);
            if (!isValidInfo)
            {
                return null;
            }
            return await _productRepository.UpdateAsync(product);
        }

        public async Task<Product> CreateProductAsync(Product product)
        {
            bool isValidInfo = ValidateProduct(product);
            if (!isValidInfo)
            {
                return null;
            }
            return await _productRepository.CreateAsync(product);
        }

        public async Task DeleteProductAsync(int id)
        {
            var product = await _productRepository.GetAsync(id);
            if(product != null)
                await _productRepository.DeleteAsync(product);
        }


        #region private
        private bool ValidateProduct(Product product)
        {
            return true;
        }

        #endregion private
    }
}
