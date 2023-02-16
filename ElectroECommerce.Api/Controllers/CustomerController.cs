using ElectroECommerce.Application.Contracts;
using ElectroECommerce.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ElectroECommerce.Api.Controllers
{
    [ApiController]
    [Route("api/customers")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomersAsync()
        {
            try
            {
                var result = await _customerService.GetCustomersAsync();
                return Ok(result);
            }
            catch(Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from server");
            }
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Customer>> GetCustomerByIdAsync(int id)
        {
            try
            {
                var result = await _customerService.GetCustomerByIdAsync(id);
                if (result == null)
                    return NotFound("Customer no existed");
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from server");
            }
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Customer>> CreateCustomerAsync(Customer customer)
        {
            try
            {
                var result = await _customerService.CreateCustomerAsync(customer);
                if (result == null)
                    return BadRequest("Object customer is null");
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from server");
            }
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult<Customer>> UpdateCustomerAsync(int id,Customer customer)
        {
            try
            {
                Customer customerIsvalid = await _customerService.GetCustomerByIdAsync(id);
                if (customerIsvalid == null)
                {
                    return BadRequest("Id = " + id + " not found in Database");
                }
                else
                {
                    customer.Id = customerIsvalid.Id;
                    var result = await _customerService.UpdateCustomerAsync(customer);
                    return Ok(result);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from server");
            }
        }

            [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult> DeleteCustomerAsync(int id)
        {
            try
            {
                var cusValid = await GetCustomerByIdAsync(id);
                if (cusValid == null)
                    return NotFound("Customer no existed");
                await _customerService.DeleteCustomerAsync(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
