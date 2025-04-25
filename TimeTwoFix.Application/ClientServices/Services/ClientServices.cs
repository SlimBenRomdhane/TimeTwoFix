using AutoMapper;
using TimeTwoFix.Application.Base;
using TimeTwoFix.Application.ClientServices.Dtos;
using TimeTwoFix.Application.ClientServices.Interfaces;
using TimeTwoFix.Core.Entities.ClientManagement;
using TimeTwoFix.Core.Interfaces.Repositories.ClientManagement;

namespace TimeTwoFix.Application.ClientServices.Services
{
    public class ClientServices : BaseService<Client>, IClientServices
    {
        IClientRepository _clientRepository;
        public ClientServices(IClientRepository clientRepository, IMapper mapper) : base(clientRepository, mapper)
        {
            _clientRepository = clientRepository;

        }

        public async Task<IEnumerable<ReadClientDto>> GetClientsByAddressAsync(string address)
        {
            var clients = await _clientRepository.GetClientsByAddressAsync(address);
            var clientsDto = _mapper.Map<IEnumerable<ReadClientDto>>(clients);
            return clientsDto;
        }

        public async Task<IEnumerable<ReadClientDto>> GetClientsByEmailAsync(string email)
        {
            var clients = await _clientRepository.GetClientsByEmailAsync(email);
            var clientsDto = _mapper.Map<IEnumerable<ReadClientDto>>(clients);
            return clientsDto;
        }

        public async Task<IEnumerable<ReadClientDto>> GetClientsByNameAsync(string name)
        {
            var clients = await _clientRepository.GetClientsByNameAsync(name);
            var clientsDto = _mapper.Map<IEnumerable<ReadClientDto>>(clients);
            return clientsDto;
        }

        public async Task<IEnumerable<ReadClientDto>> GetClientsByPhoneNumberAsync(string phoneNumber)
        {
            var clients = await _clientRepository.GetClientsByPhoneNumberAsync(phoneNumber);
            var clientsDto = _mapper.Map<IEnumerable<ReadClientDto>>(clients);
            return clientsDto;
        }

        public async Task<ReadClientDto> GetSingleClientByEmailAsync(string email)
        {
            var client = await _clientRepository.GetSingleClientByEmailAsync(email);
            if (client != null)
            {
                var clientDto = _mapper.Map<ReadClientDto>(client);
                return clientDto;
            }
            return null;

        }
    }


}
