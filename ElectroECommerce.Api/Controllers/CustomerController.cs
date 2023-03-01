using ElectroECommerce.Application.Contracts;
using ElectroECommerce.Application.Implimentations;
using ElectroECommerce.Application.Models.Request;
using ElectroECommerce.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ElectroECommerce.Api.Controllers
{
    [ApiController]
    [Route("api/customer")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Customer>> CreateCustomerAsync(CreateCustomerRequest customer)
        {
            var result = await _customerService.CreateCustomerAsync(customer);
            return Ok(result);
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult<Customer>> UpdateCustomerAsync(int id, UpdateCustomerRequest updateCustomerRequest)
        {
            var result = await _customerService.UpdateCustomerAsync(id, updateCustomerRequest);
            return Ok(result);
        }
        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Customer>> GetCustomerIdAsync(int id)
        {
            var result = await _customerService.GetCustomerByIdAsync(id);
            return Ok(result);
        }
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult> DeleteCustomerAsync(int id)
        {
            try
            {
                await _customerService.DeleteCustomerAsync(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomersAsync()
        {
            var result = await _customerService.GetCustomersAsync();
            return Ok(result);
        }
    }
}
