using ElectroECommerce.Application.Contracts;
using ElectroECommerce.Application.IRepositories;
using ElectroECommerce.Domain;

namespace ElectroECommerce.Application.Implimentations
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService (ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;  
        }

        public async Task<Customer> CreateCustomerAsync(Customer customer)
        {
            if (customer == null)
            {
                return null;
            }
            return await _customerRepository.CreateAsync(customer);
        }

        public async Task DeleteCustomerAsync(int id)
        {
            var customer = await _customerRepository.GetAsync(id);
            if(customer != null)
            {
                await _customerRepository.DeleteAsync(customer);
            }
        }

        public async Task<Customer> GetCustomerByIdAsync(int id)
        {
            return await _customerRepository.GetAsync(id);
        }

        public async Task<IEnumerable<Customer>> GetCustomersAsync()
        {
            return await _customerRepository.GetAllAsync();
        }

        public async Task<Customer> UpdateCustomerAsync(Customer customer)
        {
            if (customer != null)
            {
                var customerUpdate = await GetCustomerByIdAsync(customer.Id);
                if (customerUpdate != null)
                {
                    customerUpdate.CustomerName = customer.CustomerName;
                    customerUpdate.PhoneNumber = customer.PhoneNumber;
                    customerUpdate.CreatedBy = customer.CreatedBy;
                    customerUpdate.UpdatedBy = customer.UpdatedBy;
                    customerUpdate.Email = customer.Email;
                    customerUpdate.Status= customer.Status;
                    return await _customerRepository.UpdateAsync(customerUpdate);
                }
            }
            return null;
        }
    }
}
