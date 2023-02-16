using ElectroECommerce.Application.Contracts;
using ElectroECommerce.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ElectroECommerce.Api.Controllers
{
    [ApiController]
    [Route("api/specifications")]
    public class SpecificationsController : ControllerBase
    {
        private readonly ISpecificationsService _specificationsService;
        public SpecificationsController(ISpecificationsService specificationsService)
        {
            _specificationsService = specificationsService;
        }
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<IEnumerable<Specifications>>> GetSpecificationsAsync()
        {
            var result = await _specificationsService.GetSpecificationsAsync();
            return Ok(result);
        }
        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Specifications>> GetSpecificationByIdAsync(int id)
        {
            try
            {
                var result = await _specificationsService.GetSpecificationsByIdAsync(id);
                if (result == null)
                    return NotFound("specification no existed");
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from server");
            }
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Specifications>> CreateSpecificationsAsync(Specifications specifications)
        {
            try
            {
                var result = await _specificationsService.CreateSpecificationsAsync(specifications);
                if (result == null)
                    return BadRequest("Object specification is null");
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from server");
            }
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult<Specifications>> UpdateSpecificationsAsync(int id, Specifications specifications)
        {
            try
            {
                Specifications specIsvalid = await _specificationsService.GetSpecificationsByIdAsync(id);
                if (specIsvalid == null)
                {
                    return BadRequest("Id = " + id + " not found in Database");
                }
                else
                {
                    specifications.Id = specIsvalid.Id;
                    var result = await _specificationsService.UpdateSpecificationsAsync(specifications);
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
        public async Task<ActionResult> DeleteSpecificationsAsync(int id)
        {
            try
            {
                var specValid = await GetSpecificationByIdAsync(id);
                if (specValid == null)
                    return NotFound("Specification no existed");
                await _specificationsService.DeleteSpecificationsAsync(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
