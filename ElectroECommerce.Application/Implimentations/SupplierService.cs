using AutoMapper;
using ElectroECommerce.Application.Contracts;
using ElectroECommerce.Application.IRepositories;
using ElectroECommerce.Application.Models;
using ElectroECommerce.Application.Models.Request;
using ElectroECommerce.Domain;

namespace ElectroECommerce.Application.Implimentations
{
    public class SupplierService : ISupplierService
    {
        private readonly ICurrentUserService _curUserService;
        private readonly ISupplierRepository _supplierRepository;
        private readonly IMapper _mapper;
        public SupplierService(ICurrentUserService currentUserService,
                               ISupplierRepository supplierRepository,
                               IMapper mapper)
        {
            _curUserService = currentUserService;
            _supplierRepository = supplierRepository;
            _mapper = mapper;
        }
        public async Task<Supplier> CreateSupplierAsync(CreateSupplierRequest supplier)
        {
            var newSupplier = _mapper.Map<CreateSupplierRequest, Supplier>(supplier);
            newSupplier.SetCreateInfo(_curUserService.UserName);
            return await _supplierRepository.CreateAsync(newSupplier);
        }
        
        public async Task DeleteSupplierAsync(int id)
        {
            var supplier = await _supplierRepository.GetAsync(id);
            if (supplier != null)
            {
                await _supplierRepository.DeleteAsync(supplier);
            }
        }

        public async Task<Supplier> GetSupplierByIdAsync(int id)
        {
            return await _supplierRepository.GetAsync(id);
        }

        public async Task<IEnumerable<Supplier>> GetSuppliersAsync()
        {
            return await _supplierRepository.GetAllAsync();
        }

        public async Task<Supplier> UpdateSupplierAsync(int id, UpdateSupplierRequest updateSupplierRequest)
        {
            var updateSupplier = await _supplierRepository.GetAsync(id);
            if (updateSupplier != null)
            {
                updateSupplier.PhoneNumber = updateSupplierRequest.PhoneNumber;
                updateSupplier.Address = updateSupplierRequest.Address;
                updateSupplier.Email = updateSupplierRequest.Email;
            }
            updateSupplier.SetUpdateInfo(_curUserService.UserName);
            return await _supplierRepository.UpdateAsync(updateSupplier);
        }
    }
}
