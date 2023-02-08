﻿using ElectroECommerce.Domain;

namespace ElectroECommerce.Application.IRepositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProductsAsync();

        Task<Product> GetProductByIdAsync(int id);

        Task<Product> CreateProductAsync(Product product);

        Task<Product> UpdateProductAsync(Product product);

        Task DeleteProductAsync(int id);
    }
}
