using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTwoFix.Core.Entities.VehicleManagement;
using TimeTwoFix.Core.Interfaces.Repositories;
using TimeTwoFix.Infrastructure.Persistence.Repositories.Base;

namespace TimeTwoFix.Infrastructure.Persistence.Repositories
{
    public class VehicleRepository : BaseRepository<Vehicle>, IVehicleRepository
    {
        public VehicleRepository(TimeTwoFixDbContext context) : base(context)
        {
        }
        public async Task<IEnumerable<Vehicle>> GetVehiclesByModelAsync(string model)
        {
            var vehicles = await _context.Vehicles
                .Where(v => v.Model.Contains(model))
                .ToListAsync();
            return vehicles;
        }
        public async Task<Vehicle?> GetVehicleByVinAsync(string vin)
        {
            var vehicle = await _context.Vehicles
                .FirstOrDefaultAsync(v => v.Vin == vin);
            return vehicle;
        }

        public async Task<Vehicle?> GetVehicleByLicensePlate(string licensePlate)
        {
            var vehicle = await _context.Vehicles
                .FirstOrDefaultAsync(v => v.LicensePlate == licensePlate);
            return vehicle;
        }

        public async Task<Vehicle?> GetVehiculeByVin(string vin)
        {
            var vehicle = await _context.Vehicles
                .FirstOrDefaultAsync(v => v.Vin == vin);
            return vehicle;
        }

        public async Task<IEnumerable<Vehicle>> GetVehiclesByBrandAsync(string brand)
        {
            var vehicles = await _context.Vehicles
                .Where(v => v.Brand.Contains(brand))
                .ToListAsync();
            return vehicles;
        }

        public async Task<IEnumerable<Vehicle>> GetVehiclesByYearsRangeAsync(int startYear, int endYear)
        {
            var vehicles = await _context.Vehicles
                .Where(v => v.Year >= startYear && v.Year <= endYear)
                .ToListAsync();
            return vehicles;
        }

        public async Task<IEnumerable<Vehicle>> GetVehiclesByFuelTypeAsync(string fuelType)
        {
            var vehicles = await _context.Vehicles
                .Where(v => v.FuelType == fuelType)
                .ToListAsync();
            return vehicles;
        }

        public async Task<IEnumerable<Vehicle>> GetVehiclesByClientIdAsync(int clientId)
        {
            var vehicles = await _context.Vehicles
                .Where(v => v.ClientId == clientId)
                .ToListAsync();
            return vehicles;
        }
    }

}
