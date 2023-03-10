using AutoMapper;
using ElectroECommerce.Application.Contracts;
using ElectroECommerce.Application.IRepositories;
using ElectroECommerce.Application.Models.Request;
using ElectroECommerce.Domain;

namespace ElectroECommerce.Application.Implimentations
{
    public class PromotionDetailService : IPromotionDetailService
    {
        private readonly IPromotionDetailRepository _promotionDetailRepository;
        private readonly IMapper _mapper;
        public PromotionDetailService(IPromotionDetailRepository promotionDetailRepository, IMapper mapper)
        {
            _promotionDetailRepository = promotionDetailRepository;
            _mapper = mapper;
        }
        public async Task<PromotionDetail> CreatePromotionDetailAsync(CreatePromotionDetailRequest promotionDetail)
        {
            var newPromotionDetail = _mapper.Map<CreatePromotionDetailRequest, PromotionDetail>(promotionDetail);

            return await _promotionDetailRepository.CreateAsync(newPromotionDetail);
        }

        public async Task DeletePromotionDetailAsync(int id)
        {
            var promotionDetail = await _promotionDetailRepository.GetAsync(id);
            if (promotionDetail != null)
            {
                await _promotionDetailRepository.DeleteAsync(promotionDetail);
            }
        }

        public async Task<PromotionDetail> GetPromotionDetailByIdAsync(int id)
        {
            return await _promotionDetailRepository.GetAsync(id);
        }

        public async Task<IEnumerable<PromotionDetail>> GetPromotionDetailsAsync()
        {
            return await _promotionDetailRepository.GetAllAsync();
        }

        public async Task<PromotionDetail> UpdatePromotionDetailAsync(int id, UpdatePromotionDetailRequest updatePromotionDetailRequest)
        {
            var updatePromotionDetail = await _promotionDetailRepository.GetAsync(id);
            if (updatePromotionDetail != null)
            {
                updatePromotionDetail.DiscountType = updatePromotionDetailRequest.DiscountType;
                updatePromotionDetail.DiscountPercent = updatePromotionDetailRequest.DiscountPercent;
                updatePromotionDetail.DiscountPrice = updatePromotionDetailRequest.DiscountPrice;
                updatePromotionDetail.ProductId = updatePromotionDetailRequest.ProductId;
            }
            return await _promotionDetailRepository.UpdateAsync(updatePromotionDetail);
        }
    }
}
