using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTwoFix.Core.Entities.ClientManagement;
using TimeTwoFix.Core.Interfaces.Repositories.Base;

namespace TimeTwoFix.Core.Interfaces.Repositories
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
