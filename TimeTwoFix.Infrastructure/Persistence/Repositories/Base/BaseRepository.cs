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

        public Task<T> GetByIdAsyncGeneric(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveChangesAsyncGeneric()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsyncGeneric(T entity)
        {
            throw new NotImplementedException();
        }
    }
}