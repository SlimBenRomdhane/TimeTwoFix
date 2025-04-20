using TimeTwoFix.Core.Entities.UserManagement;
using TimeTwoFix.Infrastructure.Persistence.Repositories.Base;
using TimeTwoFix.Core.Interfaces.Repositories.IdentityManagement;
using Microsoft.EntityFrameworkCore;

namespace TimeTwoFix.Infrastructure.Persistence.Repositories.UserManagement
{
    public class ApplicationUserRepository : BaseRepository<ApplicationUser>, IApplicationUserRepository
    {
        public ApplicationUserRepository(TimeTwoFixDbContext context) : base(context)
        {
        }
        public async Task<ApplicationUser?> GetUserByEmailAsync(string email)
        {
            var applicationUser = await _context.Users
                .FirstOrDefaultAsync(u => u.Email == email);
            return applicationUser;
        }
        public async Task<IEnumerable<ApplicationUser>> GetUsersByStatusAsync(string status)
        {
            var applicationUsers = await _context.Users
                .Where(u => u.Status == status)
                .ToListAsync();
            return applicationUsers;
        }
    }

}
