using TimeTwoFix.Core.Interfaces;
using TimeTwoFix.Core.Interfaces.Repositories;
using TimeTwoFix.Infrastructure.Persistence.Repositories;

namespace TimeTwoFix.Infrastructure.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TimeTwoFixDbContext _context;
        public UnitOfWork(TimeTwoFixDbContext context)
        {
            _context = context;
            Clients = new ClientRepository(_context);
            Categories = new CategoryRepository(_context);
            Services = new ServiceRepository(_context);
            LiftingBridges = new LiftingBridgeRepository(_context);
            Skills = new SkillRepository(_context);
            Appointments = new AppointmentRepository(_context);
            InterventionSpareParts = new InterventionSparePartRepository(_context);
            SpareParts = new SparePartRepository(_context);
            Vehicles = new VehicleRepository(_context);
            WorkOrders = new WorkOrderRepository(_context);
        }
        public IClientRepository Clients { get; private set; }

        public ICategoryRepository Categories { get; private set; }

        public IServiceRepository Services { get; private set; }

        public ILiftingBridgeRepository LiftingBridges { get; private set; }

        public ISkillRepository Skills { get; private set; }

        public IAppointmentRepository Appointments { get; private set; }

        public IInterventionSparePartRepository InterventionSpareParts { get; private set; }

        public ISparePartRepository SpareParts { get; private set; }

        public IVehicleRepository Vehicles { get; private set; }

        public IWorkOrderRepository WorkOrders { get; private set; }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
