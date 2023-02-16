using ElectroECommerce.Application.IRepositories;
using ElectroECommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectroECommerce.Infrastructure.Repositories
{
    public class SpecificationsRepository : GenericRepository<Specifications>, ISpecificationsRepository
    {
        public SpecificationsRepository(AppDbContext context) : base(context)
        {
        }
    }
}
