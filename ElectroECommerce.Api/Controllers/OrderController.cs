using ElectroECommerce.Application.Contracts;
using ElectroECommerce.Application.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace ElectroECommerce.Api.Controllers
{
    [ApiController]
    [Route("api/orders/")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderSevice)
        {
            _orderService = orderSevice;
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<DtoOrder>> GetOrderByIdAsync(int id)
        {
            var result = await _orderService.GetOrderByIdAsync(id);
            return Ok(result);
        }
    }
}
