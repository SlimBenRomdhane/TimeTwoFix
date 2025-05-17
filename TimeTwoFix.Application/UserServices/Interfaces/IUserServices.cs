using TimeTwoFix.Application.Base;
using TimeTwoFix.Application.UserServices.Dtos;
using TimeTwoFix.Core.Entities.UserManagement;

namespace TimeTwoFix.Application.UserServices.Interfaces
{
    public interface IUserServices
    {
        Task<IEnumerable<ReadUserDto>> GetUsersByMultipleParam(UserFilterDto userFilterDto);

        Task<IEnumerable<ReadUserDto>> GetAllApplicationUsers();

        Task<IEnumerable<ReadRoleDto>> GetAllApplicationRoles();
    }
}