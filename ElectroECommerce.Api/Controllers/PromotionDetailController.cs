using ElectroECommerce.Application.Contracts;
using ElectroECommerce.Application.Implimentations;
using ElectroECommerce.Application.Models.Request;
using ElectroECommerce.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ElectroECommerce.Api.Controllers
{
    [ApiController]
    [Route("api/promotionDetail")]
    public class PromotionDetailController : ControllerBase
    {
        private readonly IPromotionDetailService _promotionDetailService;
        public PromotionDetailController(IPromotionDetailService promotionDetailService)
        {
            _promotionDetailService = promotionDetailService;
        }
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<IEnumerable<PromotionDetail>>> GetPromotionDetailsAsync()
        {
            try
            {
                var result = await _promotionDetailService.GetPromotionDetailsAsync();
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from server");
            }
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<PromotionDetail>> GetPromotionDetailByIdAsync(int id)
        {
            try
            {
                var result = await _promotionDetailService.GetPromotionDetailByIdAsync(id);
                if (result == null)
                    return NotFound("PromotionDetail no existed");
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from server");
            }
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<PromotionDetail>> CreatePromotionDetailAsync(CreatePromotionDetailRequest promotionDetail)
        {
            try
            {
                var result = await _promotionDetailService.CreatePromotionDetailAsync(promotionDetail);
                if (result == null)
                    return BadRequest("Object promotionDetail is null");
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from server");
            }
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult<PromotionDetail>> UpdatePromotionDetailAsync(int id, UpdatePromotionDetailRequest updatePromotionDetailRequest)
        {
            try
            {

                PromotionDetail promodetailIsvalid = await _promotionDetailService.GetPromotionDetailByIdAsync(id);
                if (promodetailIsvalid == null)
                {
                    return BadRequest("Id = " + id + " not found in Database");
                }
                else
                {
                    var result = await _promotionDetailService.UpdatePromotionDetailAsync(id, updatePromotionDetailRequest);
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
        public async Task<ActionResult> DeletePromotionDetailAsync(int id)
        {
            try
            {
                var cusValid = await GetPromotionDetailByIdAsync(id);
                if (cusValid == null)
                    return NotFound("PromotionDetail no existed");
                await _promotionDetailService.DeletePromotionDetailAsync(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}

