using ElectroECommerce.Application.Contracts;
using ElectroECommerce.Application.Implimentations;
using ElectroECommerce.Application.Models.Dtos;
using ElectroECommerce.Application.Models.Request;
using ElectroECommerce.Domain;
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
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<DtoOrder>> GetAllOrderAsync()
        {
            var result = await _orderService.GetAllOrderAsync();
            return Ok(result);
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Order>> CreateOrderAsync(CreateOrderRequest order)
        {
            var result = await _orderService.CreateOrderAsync(order);
            return Ok(result);
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult<Order>> UpdateOrderAsync(UpdateOrderRequest order, int id)
        {
            var result = await _orderService.UpdateOrderAsync(order, id);
            return Ok(result);
        }
        [HttpDelete]
        [Route("{id:int}")]
        public  async Task DeleteOrderAsync(int id)
        { 
             await _orderService.DeleteOrderAsync(id);
        }
    }
}
