using Microsoft.EntityFrameworkCore;
using TimeTwoFix.Core.Entities.BridgeManagement;
using TimeTwoFix.Core.Interfaces.Repositories;
using TimeTwoFix.Infrastructure.Persistence.Repositories.Base;

namespace TimeTwoFix.Infrastructure.Persistence.Repositories
{
    public class LiftingBridgeRepository : BaseRepository<LiftingBridge>, ILiftingBridgeRepository
    {
        private readonly TimeTwoFixDbContext _context;
        public LiftingBridgeRepository(TimeTwoFixDbContext context) : base(context)
        {
            _context = context;
        }
        // Implement the methods from ILiftingBridgeRepository here
        public async Task<IEnumerable<LiftingBridge>> GetLiftingBridgesByLoadCapacityAsync(int loadCapacity)
        {
            return await _context.LiftingBridges
                .Where(l => l.LoadCapacity == loadCapacity)
                .ToListAsync();
        }
        public async Task<IEnumerable<LiftingBridge>> GetLiftingBridgesByStatusAsync(string status)
        {
            return await _context.LiftingBridges
                .Where(l => l.Status == status)
                .ToListAsync();
        }
    }

}
