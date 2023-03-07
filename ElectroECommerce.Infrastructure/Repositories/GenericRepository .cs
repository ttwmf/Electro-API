using ElectroECommerce.Application.Common.Constants;
using ElectroECommerce.Application.IRepositories;
using ElectroECommerce.Domain;
using Microsoft.EntityFrameworkCore;

namespace ElectroECommerce.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        protected readonly AppDbContext _context;
        protected DbSet<T> _entity;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _entity = _context.Set<T>();
        }

        public virtual async Task<T> CreateAsync(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _entity.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public virtual async Task DeleteAsync(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entity.Status = CommonConstant.DELETED;
            await _context.SaveChangesAsync();
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _entity.ToListAsync();
        }

        public virtual async Task<T> GetAsync(int id)
        {
            return await _entity.FirstOrDefaultAsync(x => x.Id == id);
        }

        public virtual async Task<T> UpdateAsync(T entity)
        {
            _entity.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
