using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TimeTwoFix.Core.Entities.UserManagement
{
    public class ApplicationUser : IdentityUser<int>
    {
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(100)]
        public string Address { get; set; }

        [MaxLength(50)]
        public string City { get; set; }

        public int ZipCode { get; set; }
        public string? ImageUrl { get; set; }

        [Required]
        public DateOnly HireDate { get; set; }

        public decimal HourlyWage { get; set; }

        [Range(0, 50)]
        public int yearsOfExperience { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastEmployer { get; set; }

        //Indicates if the user is currently employed, on leave, or terminated...
        [Required]
        [MaxLength(50)]
        public string Status { get; set; }
    }
}