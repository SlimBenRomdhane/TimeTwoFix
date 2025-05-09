﻿using TimeTwoFix.Core.Entities.VehicleManagement;
using TimeTwoFix.Core.Interfaces.Repositories.Base;

namespace TimeTwoFix.Core.Interfaces.Repositories.VehicleManagement
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