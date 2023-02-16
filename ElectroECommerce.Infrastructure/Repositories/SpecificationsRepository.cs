using ElectroECommerce.Application.IRepositories;
using ElectroECommerce.Domain;

namespace ElectroECommerce.Infrastructure.Repositories
{
    public class SpecificationsRepository : GenericRepository<Specifications>, ISpecificationsRepository
    {
        public SpecificationsRepository(AppDbContext context) : base(context)
        {
        }
    }
}
