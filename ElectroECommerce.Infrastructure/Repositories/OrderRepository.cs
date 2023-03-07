using ElectroECommerce.Application.IRepositories;
using ElectroECommerce.Domain;
using Microsoft.EntityFrameworkCore;

namespace ElectroECommerce.Infrastructure.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(AppDbContext context) : base(context)
        {

        }

        public override async Task<Order> GetAsync(int id)
        {
            return await _entity.Include(a => a.Customer).Include(a => a.OrderDetails).ThenInclude(a => a.Product).FirstOrDefaultAsync(a => a.Id == id);
        }
        public override async Task<IEnumerable<Order>> GetAllAsync()
        {
            return await _entity
                .Include(a => a.Customer)
                .Include(a => a.OrderDetails)
                    .ThenInclude(a => a.Product)
                        .ThenInclude(a => a.Supplier)
                .Include(a => a.OrderDetails)
                    .ThenInclude(a => a.Product)
                        .ThenInclude(a => a.Specifications)
                .ToListAsync();
        }
    }
}
