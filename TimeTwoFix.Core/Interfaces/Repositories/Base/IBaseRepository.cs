namespace TimeTwoFix.Core.Interfaces.Repositories.Base
{
    public interface IBaseRepository<T> where T : class
    {
        Task AddAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);

        Task<T> GetByIdAsync(int id);

        Task<IEnumerable<T>> GetAllAsync();

        Task<bool> SaveChangesAsync();
    }
}