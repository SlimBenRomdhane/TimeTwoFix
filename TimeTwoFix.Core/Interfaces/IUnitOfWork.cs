using TimeTwoFix.Core.Interfaces.Repositories;

namespace TimeTwoFix.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IClientRepository Clients { get; }
        IVehicleRepository Vehicles { get; }
        //IWorkOrderRepository WorkOrders { get; }
        //IInterventionRepository Interventions { get; }
        IInterventionSparePartRepository InterventionSpareParts { get; }
        ICategoryRepository Categories { get; }
        IServiceRepository Services { get; }
        ILiftingBridgeRepository LiftingBridges { get; }
        ISkillRepository Skills { get; }
        //IMechanicSkillRepository MechanicSkills { get; }
        IAppointmentRepository Appointments { get; }
        ISparePartRepository SpareParts { get; }
        //IFrontDeskAssistantRepository FrontDeskAssistants { get; }
        //IMechanicRepository Mechanics { get; }
        //IWareHouseManagerRepository WareHouseManagers { get; }
        //IWorkshopManagerRepository WorkshopManagers { get; }
        //IGeneralManagerRepository GeneralManagers { get; }
        Task<int> SaveChangesAsync();
    }

}
