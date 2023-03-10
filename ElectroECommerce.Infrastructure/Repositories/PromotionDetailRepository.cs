using ElectroECommerce.Application.IRepositories;
using ElectroECommerce.Domain;

namespace ElectroECommerce.Infrastructure.Repositories
{
    public class PromotionDetailRepository : GenericRepository<PromotionDetail>, IPromotionDetailRepository
    {
        public PromotionDetailRepository(AppDbContext context) : base(context)
        {

        }
    }
}
