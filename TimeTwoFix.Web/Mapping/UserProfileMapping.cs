using AutoMapper;
using TimeTwoFix.Application.UserServices.Dtos;
using TimeTwoFix.Core.Entities.UserManagement;
using TimeTwoFix.Web.Models.UserModels;

namespace TimeTwoFix.Web.Mapping
{
    public class UserProfileMapping : Profile
    {
        public UserProfileMapping()
        {
            CreateMap<ReadUserDto, ReadUserViewModel>().ReverseMap();
            CreateMap<ApplicationUser, ReadUserDto>();
            CreateMap<ApplicationRole, ReadRoleViewModel>();

            CreateMap<ReadUserDto, Mechanic>().ReverseMap();
            CreateMap<ReadUserDto, FrontDeskAssistant>().ReverseMap();
            CreateMap<ReadUserDto, WareHouseManager>().ReverseMap();
            CreateMap<ReadUserDto, GeneralManager>().ReverseMap();
            CreateMap<ReadUserDto, WorkshopManager>().ReverseMap();

            //Entity To ViewModel
            CreateMap<Mechanic, ReadUserViewModel>();
            CreateMap<FrontDeskAssistant, ReadUserViewModel>();
            CreateMap<WareHouseManager, ReadUserViewModel>();
            //View To Dto
            CreateMap<CreateFrontDeskAssistantViewModel, ReadUserDto>().ReverseMap();
            CreateMap<CreateMechanicViewModel, ReadUserDto>().ReverseMap();
            CreateMap<CreateWareHouseManagerViewModel, ReadUserDto>().ReverseMap();


        }
    }
}
