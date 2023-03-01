using ElectroECommerce.Application.Models.Request;
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

        Task<Customer> UpdateCustomerAsync(int id, UpdateCustomerRequest updateCustomerRequest);

        Task<Customer> CreateCustomerAsync(CreateCustomerRequest product);

        Task DeleteCustomerAsync(int id);
    }
}
