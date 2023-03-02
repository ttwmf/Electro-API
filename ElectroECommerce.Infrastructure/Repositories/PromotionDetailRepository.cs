using ElectroECommerce.Application.IRepositories;
using ElectroECommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectroECommerce.Infrastructure.Repositories
{
    public class PromotionDetailRepository : GenericRepository<PromotionDetail>, IPromotionDetailRepository
    {
        public PromotionDetailRepository(AppDbContext context) : base(context)
        {

        }
    }
}
