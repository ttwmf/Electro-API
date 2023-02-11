using ElectroECommerce.Application.Contracts;
using ElectroECommerce.Application.IRepositories;
using ElectroECommerce.Domain;

namespace ElectroECommerce.Application.Implimentations
{
    public class PromotionService : IPromotionService
    {
        private readonly IPromotionRepository _promotionRepository;
        public PromotionService(IPromotionRepository promotionRepository)
        {
            _promotionRepository = promotionRepository;
        }
        public async Task<Promotion> CreatePromotionAsync(Promotion promotion)
        {
            return await _promotionRepository.CreateAsync(promotion);
        }

        public async Task DeletePromotionAsync(int id)
        {
            var result = await _promotionRepository.GetAsync(id);
            if (result != null)
            {
                await _promotionRepository.DeleteAsync(result);
            }
        }


        public async Task<Promotion> GetPromotionByIdAsync(int id)
        {
            return await _promotionRepository.GetAsync(id);
        }

        public async Task<IEnumerable<Promotion>> GetPromotionsAsync()
        {
            return await _promotionRepository.GetAllAsync();
        }

        public async Task<Promotion> UpdatePromotionAsync(Promotion promotion)
        {
            return await _promotionRepository.UpdateAsync(promotion);
        }
    }
}
