using ElectroECommerce.Application.Contracts;
using ElectroECommerce.Application.IRepositories;
using ElectroECommerce.Application.Models.Request;
using ElectroECommerce.Domain;

namespace ElectroECommerce.Application.Implimentations
{
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository _supplierRepository;
        public SupplierService(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }
        public async Task<Supplier> CreateSupplierAsync(CreateSupplierRequest supplier)
        {
            var newSupplier = new Supplier()
            {
                Address = supplier.Address,
                PhoneNumber = supplier.PhoneNumber,
                SupplierName = supplier.SupplierName,
                Email = supplier.Email,

                //TODO 
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.Now,
                CreatedBy = "Thai",
                Status = 0
            };
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

        public async Task<Supplier> UpdateSupplierAsync(Supplier supplier)
        {

            return await _supplierRepository.UpdateAsync(supplier);
        }
    }
}
