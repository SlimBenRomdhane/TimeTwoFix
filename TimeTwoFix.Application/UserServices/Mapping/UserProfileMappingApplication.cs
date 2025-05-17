using AutoMapper;
using TimeTwoFix.Application.UserServices.Dtos;
using TimeTwoFix.Core.Entities.UserManagement;

namespace TimeTwoFix.Application.UserServices.Mapping
{
    public class UserProfileMappingApplication : Profile
    {
        public UserProfileMappingApplication()
        {

            CreateMap<ApplicationUser, ReadUserDto>().ReverseMap();
            CreateMap<UpdateUserDto, ApplicationUser>();
            CreateMap<DeleteUserDto, ApplicationUser>();
            CreateMap<CreateUserDto, ApplicationUser>();

        }
    }
}