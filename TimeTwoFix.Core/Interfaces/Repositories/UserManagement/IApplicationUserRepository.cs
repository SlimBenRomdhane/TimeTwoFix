using TimeTwoFix.Core.Entities.UserManagement;
using TimeTwoFix.Core.Interfaces.Repositories.Base;

namespace TimeTwoFix.Core.Interfaces.Repositories.IdentityManagement
{
    public interface IApplicationUserRepository : IBaseRepository<ApplicationUser>
    {
        Task<ApplicationUser?> GetUserByEmailAsync(string email);

        Task<IEnumerable<ApplicationUser>> GetUsersByStatusAsync(string status);
    }
}