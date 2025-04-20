using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTwoFix.Core.Entities.VehicleManagement;
using TimeTwoFix.Core.Interfaces.Repositories.Base;

namespace TimeTwoFix.Core.Interfaces.Repositories
{
    public interface IVehicleRepository : IBaseRepository<Vehicle>
    {
        Task<Vehicle?> GetVehicleByLicensePlate(string licensePlate);
        Task<Vehicle?> GetVehiculeByVin(string vin);
        Task<IEnumerable<Vehicle>> GetVehiclesByBrandAsync(string brand);
        Task<IEnumerable<Vehicle>> GetVehiclesByModelAsync(string model);
        Task<IEnumerable<Vehicle>> GetVehiclesByYearsRangeAsync(int startYear, int endYear);
        Task<IEnumerable<Vehicle>> GetVehiclesByFuelTypeAsync(string fuelType);
        Task<IEnumerable<Vehicle>> GetVehiclesByClientIdAsync(int clientId);
    }
}
