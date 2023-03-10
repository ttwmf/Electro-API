using ElectroECommerce.Application.Models.Request;
using ElectroECommerce.Domain;

namespace ElectroECommerce.Application.Contracts
{
    public interface IPromotionDetailService
    {

        Task<IEnumerable<PromotionDetail>> GetPromotionDetailsAsync();

        Task<PromotionDetail> GetPromotionDetailByIdAsync(int id);

        Task<PromotionDetail> UpdatePromotionDetailAsync(int id, UpdatePromotionDetailRequest updatePromotionDetailRequest);

        Task<PromotionDetail> CreatePromotionDetailAsync(CreatePromotionDetailRequest product);

        Task DeletePromotionDetailAsync(int id);
    }
}
