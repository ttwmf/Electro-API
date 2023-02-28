using AutoMapper;
using ElectroECommerce.Application.Contracts;
using ElectroECommerce.Application.IRepositories;
using ElectroECommerce.Application.Models.Request;
using ElectroECommerce.Domain;

namespace ElectroECommerce.Application.Implimentations
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;
        public CustomerService(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public async Task<Customer> CreateCustomerAsync(CreateCustomerRequest customer)
        {
            var newCustomer = _mapper.Map<CreateCustomerRequest, Customer>(customer);

            return await _customerRepository.CreateAsync(newCustomer);
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

        public async Task<Customer> UpdateCustomerAsync(int id, UpdateCustomerRequest updateCustomerRequest)
        {
            var updateCustomer = await _customerRepository.GetAsync(id);
            if (updateCustomer != null)
            {
                updateCustomer.PhoneNumber = updateCustomerRequest.PhoneNumber;
                updateCustomer.Address = updateCustomerRequest.Address;
                updateCustomer.Email = updateCustomerRequest.Email;
                updateCustomer.Username = updateCustomerRequest.Username;
                updateCustomer.password = updateCustomerRequest.password;

            }
            return await _customerRepository.UpdateAsync(updateCustomer);
        }
    }
}
