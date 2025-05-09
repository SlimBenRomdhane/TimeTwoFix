using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TimeTwoFix.Core.Entities.UserManagement
{
    public class ApplicationRole : IdentityRole<int>
    {
        [MaxLength(100)]
        public string Description { get; set; }

        public bool IsActive { get; set; }
        //public ApplicationRole()
        //{
        //}
        //public ApplicationRole(string roleName) : base(roleName)
        //{
        //}
    }
}