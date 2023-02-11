using ElectroECommerce.Application.IRepositories;
using ElectroECommerce.Domain;

namespace ElectroECommerce.Infrastructure.Repositories
{
    public class PromotionRepository : GenericRepository<Promotion>, IPromotionRepository
    {
        public PromotionRepository(AppDbContext context) : base(context)
        {

        }
    }
}
