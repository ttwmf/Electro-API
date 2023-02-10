using ElectroECommerce.Domain;

namespace ElectroECommerce.Application.Contracts
{
    public interface ISupplierService
    {
        Task<IEnumerable<Supplier>> GetSuppliersAsync();

        Task<Supplier> GetSupplierByIdAsync(int id);

        Task<Supplier> UpdateSupplierAsync(Supplier product);

        Task<Supplier> CreateSupplierAsync(Supplier product);

        Task DeleteSupplierAsync(int id);
    }
}
