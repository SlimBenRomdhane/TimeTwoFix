using AutoMapper;
using TimeTwoFix.Application.ClientServices.Dtos;
using TimeTwoFix.Core.Entities.ClientManagement;

namespace TimeTwoFix.Application.ClientServices.Mapping
{
    public class UserProfileMappingApplication : Profile
    {
        public UserProfileMappingApplication()
        {
            CreateMap<Client, ReadClientDto>().ReverseMap();
            CreateMap<CreateClientDto, Client>();
            CreateMap<UpdateClientDto, Client>().ReverseMap();
        }
    }
}