using AutoMapper;
using TimeTwoFix.Application.Base;
using TimeTwoFix.Core.Entities.ClientManagement;
using TimeTwoFix.Core.Interfaces;
using TimeTwoFix.Application.ClientServices.Dtos;

namespace TimeTwoFix.Application.ClientServices.Services
{
    public class ClientService : BaseService<Client>, TimeTwoFix.Application.ClientServices.Interfaces.IClientServices
    {
        public ClientService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IEnumerable<ReadClientDto>> GetClientsByAddressAsync(string address)
        {
            var res = await _unitOfWork.Clients.GetClientsByAddressAsync(address);
            var clientsDto = _mapper.Map<IEnumerable<ReadClientDto>>(res);
            return clientsDto;
        }

        public async Task<IEnumerable<ReadClientDto>> GetClientsByEmailAsync(string email)
        {
            var res = await _unitOfWork.Clients.GetClientsByEmailAsync(email);
            var clientsDto = _mapper.Map<IEnumerable<ReadClientDto>>(res);
            return clientsDto;
        }

        public async Task<IEnumerable<ReadClientDto>> GetClientsByNameAsync(string name)
        {
            var res = await _unitOfWork.Clients.GetClientsByNameAsync(name);
            var clientsDto = _mapper.Map<IEnumerable<ReadClientDto>>(res);
            return clientsDto;
        }

        public async Task<IEnumerable<ReadClientDto>> GetClientsByPhoneNumberAsync(string phoneNumber)
        {
            var res = await _unitOfWork.Clients.GetClientsByPhoneNumberAsync(phoneNumber);
            var clientsDto = _mapper.Map<IEnumerable<ReadClientDto>>(res);
            return clientsDto;
        }

        public async Task<ReadClientDto> GetSingleClientByEmailAsync(string email)
        {
            var res = await _unitOfWork.Clients.GetSingleClientByEmailAsync(email);
            if (res == null)
            {
                throw new Exception("Client not found");
            }
            var clientDto = _mapper.Map<ReadClientDto>(res);
            return clientDto;
        }
    }

}
