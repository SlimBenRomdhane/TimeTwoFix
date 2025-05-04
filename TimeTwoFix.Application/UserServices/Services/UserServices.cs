using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTwoFix.Application.Base;
using TimeTwoFix.Application.UserServices.Interfaces;
using TimeTwoFix.Core.Entities.UserManagement;
using TimeTwoFix.Core.Interfaces;

namespace TimeTwoFix.Application.UserServices.Services
{
    public class UserServices : BaseService<ApplicationUser>, IUserServices
    {
        public UserServices(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IEnumerable<ApplicationUser>> GetAllUsers()
        {
            var res = await _unitOfWork.ApplicationUsers.GetAllUsers();
            if (res == null)
            {
                throw new Exception("Users not found");
            }
            return res;

        }

        public async Task<IEnumerable<ApplicationRole>> GetApplicationRoles()
        {
            var res = await _unitOfWork.ApplicationUsers.GetAllRoles();
            if (res == null)
            {
                throw new Exception("Roles not found");
            }
            return res;
        }

        public Task<IEnumerable<ApplicationUser>> GetUsersByAddressAsync(string address)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ApplicationUser>> GetUsersByCityAsync(string city)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ApplicationUser>> GetUsersByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ApplicationUser>> GetUsersByFirstNameAsync(string firstName)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ApplicationUser>> GetUsersByHireDateAsync(DateTime hireDate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ApplicationUser>> GetUsersByLastNameAsync(string lastName)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ApplicationUser>> GetUsersByPhoneNumberAsync(string phoneNumber)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ApplicationUser>> GetUsersByPostalCodeAsync(int postalCode)
        {
            throw new NotImplementedException();
        }
    }
}
