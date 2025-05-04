using System.ComponentModel.DataAnnotations;

namespace TimeTwoFix.Web.Models.UserModels
{
    public class CreateFrontDeskAssistantViewModel
    {
        //Common properties
        [Required, MaxLength(50)]
        public required string FirstName { get; set; }
        [Required, MaxLength(50)]
        public required string LastName { get; set; }
        [Required, MaxLength(10)]
        public required string Address { get; set; }
        [Required, MaxLength(50)]
        public string City { get; set; }
        public int ZipCode { get; set; }
        [Required, MaxLength(50)]
        public required string PhoneNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string ImageURL { get; set; }
        [DataType(DataType.Date)]
        public DateOnly HireDate { get; set; }
        public int YearsOfExperience { get; set; }
        public string LastEmployer { get; set; }
        public string Status { get; set; }


        //Assistant properties
        public string? WorkStationNumber { get; set; }
        public string? PhoneExtension { get; set; }
        public string? SpokenLanguage { get; set; }
        public bool BusinessKnowledge { get; set; }

    }
}
