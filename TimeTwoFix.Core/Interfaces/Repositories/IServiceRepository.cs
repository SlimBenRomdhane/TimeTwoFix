using TimeTwoFix.Core.Entities.ServiceManagement;
using TimeTwoFix.Core.Interfaces.Repositories.Base;

namespace TimeTwoFix.Core.Interfaces.Repositories
{
    public interface IServiceRepository : IBaseRepository<Service>
    {
        Task<IEnumerable<Service>> GetServicesByNameAsync(string name);
        Task<IEnumerable<Service>> GetServicesByStatusAsync(string status);
        Task<IEnumerable<Service>> GetServicesByCategoryIdAsync(int categoryId);
    }
}
