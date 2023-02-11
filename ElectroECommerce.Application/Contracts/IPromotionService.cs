using ElectroECommerce.Domain;

namespace ElectroECommerce.Application.Contracts
{
    public interface IPromotionService
    {
        Task<IEnumerable<Promotion>> GetPromotionsAsync();

        Task<Promotion> GetPromotionByIdAsync(int id);

        Task<Promotion> UpdatePromotionAsync(Promotion promotion);

        Task<Promotion> CreatePromotionAsync(Promotion promotion);

        Task DeletePromotionAsync(int id);
    }
}
