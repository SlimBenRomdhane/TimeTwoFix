using Microsoft.EntityFrameworkCore;
using TimeTwoFix.Core.Interfaces.Repositories.Base;

namespace TimeTwoFix.Infrastructure.Persistence.Repositories.Base
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly TimeTwoFixDbContext _context;
        private readonly DbSet<T> _dbSet;

        public BaseRepository(TimeTwoFixDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<T> AddAsyncGeneric(T entity)
        {
            await _dbSet.AddAsync(entity);
            return entity;
        }

        public async Task DeleteAsyncGeneric(T entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsyncGeneric()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T?> GetByIdAsyncGeneric(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<int> SaveChangesAsyncGeneric()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task UpdateAsyncGeneric(T entity)
        {
            _dbSet.Update(entity);
        }
    }
}