using ElectroECommerce.Application.Contracts;
using ElectroECommerce.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ElectroECommerce.Api.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        /// <summary>
        /// Get products asynchronously
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProductsAsync()
        {
            var result = await _productService.GetProductsAsync();
            return Ok(result);
        }

        /// <summary>
        /// Get prodcut asynchronously
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Product>> GetProductByIdAsync(int id)
        {
            var result = await _productService.GetProductByIdAsync(id);
            return Ok(result);
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Product>> CreateProductAsync(Product product)
        {
            var result = await _productService.CreateProductAsync(product);
            return Ok(result);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult<Product>> UpdateProductAsync(Product product)
        {
            var result = await _productService.UpdateProductAsync(product);
            return Ok(result);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult> DeleteProductAsync(int id)
        {
            try
            {
                await _productService.DeleteProductAsync(id);
                return Ok();
            } 
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError ,ex.Message);
            }
        }

    }
}
