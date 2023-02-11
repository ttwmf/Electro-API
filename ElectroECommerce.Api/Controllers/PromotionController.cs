using ElectroECommerce.Application.Contracts;
using ElectroECommerce.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ElectroECommerce.Api.Controllers
{
    [ApiController]
    [Route("promotion/promotions")]
    public class PromotionController : ControllerBase
    {
        private readonly IPromotionService _promotionService;
        public PromotionController(IPromotionService promotionService)
        {
            _promotionService = promotionService;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Promotion>> GetPromotionAsync(int id)
        {
            var result = await _promotionService.GetPromotionByIdAsync(id);
            return Ok(result);
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Promotion>> CreatePromotionAsync(Promotion promotion)
        {
            var result = await _promotionService.CreatePromotionAsync(promotion);
            return Ok(result);
        }

    }
}
