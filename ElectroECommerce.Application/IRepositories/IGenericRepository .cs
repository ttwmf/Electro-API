using ElectroECommerce.Domain;

namespace ElectroECommerce.Application.IRepositories
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<T> GetAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();

        Task SaveAsync();
    }
}
