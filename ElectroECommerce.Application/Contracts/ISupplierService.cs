using ElectroECommerce.Application.Models.Request;
using ElectroECommerce.Domain;

namespace ElectroECommerce.Application.Contracts
{
    public interface ISupplierService
    {
        Task<IEnumerable<Supplier>> GetSuppliersAsync();

        Task<Supplier> GetSupplierByIdAsync(int id);

        Task<Supplier> UpdateSupplierAsync(int id, UpdateSupplierRequest updateSupplierRequest);

        Task<Supplier> CreateSupplierAsync(CreateSupplierRequest product);

        Task DeleteSupplierAsync(int id);
    }
}
