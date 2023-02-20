using ElectroECommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectroECommerce.Application.Contracts
{
    public interface ISpecificationsService
    {
        Task<IEnumerable<Specifications>> GetSpecificationsAsync();

        Task<Specifications> GetSpecificationsByIdAsync(int id);

        Task<Specifications> UpdateSpecificationsAsync(Specifications specifications);

        Task<Specifications> CreateSpecificationsAsync(Specifications specifications);

        Task DeleteSpecificationsAsync(int id);
    }
}

