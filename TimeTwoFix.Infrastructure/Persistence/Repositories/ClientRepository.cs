using Microsoft.EntityFrameworkCore;
using TimeTwoFix.Core.Entities.ClientManagement;
using TimeTwoFix.Core.Interfaces.Repositories;
using TimeTwoFix.Infrastructure.Persistence.Repositories.Base;

namespace TimeTwoFix.Infrastructure.Persistence.Repositories
{
    public class ClientRepository : BaseRepository<Client>, IClientRepository
    {
        public ClientRepository(TimeTwoFixDbContext context) : base(context) { }
        public async Task<IEnumerable<Client>> GetClientsByNameAsync(string name)
        {
            return await _context.Clients
                .Where(c => c.FirstName.Contains(name) || c.LastName.Contains(name))
                .ToListAsync();
        }
        public async Task<IEnumerable<Client>> GetClientsByEmailAsync(string email)
        {
            return await _context.Clients.Where(c => c.Email.Contains(email)).ToListAsync();
        }
        public async Task<Client> GetSingleClientByEmailAsync(string email)
        {
            var client = await _context.Clients.FirstOrDefaultAsync(c => c.Email == email);
            if (client == null)
                throw new Exception("Client not found");
            return client;
        }
        public async Task<IEnumerable<Client>> GetClientsByPhoneNumberAsync(string phoneNumber)
        {
            return await _context.Clients.Where(c => c.PhoneNumber.Contains(phoneNumber)).ToListAsync();
        }
        public async Task<IEnumerable<Client>> GetClientsByAddressAsync(string address)
        {
            return await _context.Clients.Where(c => c.Address.Contains(address)).ToListAsync();
        }
    }
}
