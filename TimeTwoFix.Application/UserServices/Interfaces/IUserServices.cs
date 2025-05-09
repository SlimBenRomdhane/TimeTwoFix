using TimeTwoFix.Application.Base;
using TimeTwoFix.Core.Entities.UserManagement;

namespace TimeTwoFix.Application.UserServices.Interfaces
{
    public interface IUserServices : IBaseService<ApplicationUser>
    {
        Task<IEnumerable<ApplicationUser>> GetUsersByFirstNameAsync(string firstName);

        Task<IEnumerable<ApplicationUser>> GetUsersByLastNameAsync(string lastName);

        Task<IEnumerable<ApplicationUser>> GetUsersByEmailAsync(string email);

        Task<IEnumerable<ApplicationUser>> GetUsersByPhoneNumberAsync(string phoneNumber);

        Task<IEnumerable<ApplicationUser>> GetUsersByAddressAsync(string address);

        Task<IEnumerable<ApplicationUser>> GetUsersByCityAsync(string city);

        Task<IEnumerable<ApplicationUser>> GetUsersByPostalCodeAsync(int postalCode);

        Task<IEnumerable<ApplicationUser>> GetUsersByHireDateAsync(DateTime hireDate);

        Task<IEnumerable<ApplicationUser>> GetAllUsers();

        Task<IEnumerable<ApplicationRole>> GetApplicationRoles();
    }
}