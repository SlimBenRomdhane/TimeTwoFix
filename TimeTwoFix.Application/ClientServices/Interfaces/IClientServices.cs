using TimeTwoFix.Application.Base;
using TimeTwoFix.Application.ClientServices.Dtos;
using TimeTwoFix.Core.Entities.ClientManagement;

namespace TimeTwoFix.Application.ClientServices.Interfaces
{
    public interface IClientServices : IBaseService<Client>
    {
        Task<IEnumerable<ReadClientDto>> GetClientsByNameAsync(string name);
        Task<IEnumerable<ReadClientDto>> GetClientsByEmailAsync(string email);
        Task<ReadClientDto> GetSingleClientByEmailAsync(string email);
        Task<IEnumerable<ReadClientDto>> GetClientsByPhoneNumberAsync(string phoneNumber);
        Task<IEnumerable<ReadClientDto>> GetClientsByAddressAsync(string address);

    }
}
