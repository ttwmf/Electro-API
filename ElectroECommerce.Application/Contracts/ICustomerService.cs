using ElectroECommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectroECommerce.Application.Contracts
{
    public interface ICustomerService
    {
        Task<IEnumerable<Customer>> GetCustomersAsync();

        Task<Customer> GetCustomerByIdAsync(int id);

        Task<Customer> UpdateCustomerAsync(Customer customer);

        Task<Customer> CreateCustomerAsync(Customer customer);

        Task DeleteCustomerAsync(int id);
    }
}
