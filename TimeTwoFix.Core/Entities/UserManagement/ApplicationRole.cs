using Microsoft.AspNetCore.Identity;

namespace TimeTwoFix.Core.Entities.UserManagement
{
    public class ApplicationRole : IdentityRole<int>
    {
        public ApplicationRole(string roleName) : base(roleName)
        {
        }
    }
}