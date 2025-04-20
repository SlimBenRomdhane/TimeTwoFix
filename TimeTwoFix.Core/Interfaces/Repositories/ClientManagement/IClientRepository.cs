using TimeTwoFix.Core.Entities.ClientManagement;
using TimeTwoFix.Core.Interfaces.Repositories.Base;

namespace TimeTwoFix.Core.Interfaces.Repositories.ClientManagement
{
    public interface IClientRepository : IBaseRepository<Client>
    {
        Task<IEnumerable<Client>> GetClientsByNameAsync(string name);

        Task<IEnumerable<Client>> GetClientsByEmailAsync(string email);

        Task<Client> GetSingleClientByEmailAsync(string email);

        Task<IEnumerable<Client>> GetClientsByPhoneNumberAsync(string phoneNumber);

        Task<IEnumerable<Client>> GetClientsByAddressAsync(string address);
    }
}