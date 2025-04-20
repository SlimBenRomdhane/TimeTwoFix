using System.ComponentModel.DataAnnotations.Schema;
using TimeTwoFix.Core.Common;
using TimeTwoFix.Core.Entities.BridgeManagement;
using TimeTwoFix.Core.Entities.IdentityManagement;
using TimeTwoFix.Core.Entities.ServiceManagement;
using TimeTwoFix.Core.Entities.SparePartManagement;

namespace TimeTwoFix.Core.Entities.WorkOrderManagement
{
    public class Intervention : BaseEntity
    {
        [ForeignKey("WorkOrder")]
        public int WorkOrderId { get; set; }

        [ForeignKey("Mechanic")]
        public int MechanicId { get; set; }

        [ForeignKey("Service")]
        public int ServiceId { get; set; }

        [ForeignKey("LiftingBridge")]
        public int LiftingBridgeId { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ActualTimeSpent { get; set; }
        public decimal InterventionPrice { get; set; }
        public Mechanic Mechanic { get; set; }
        public WorkOrder WorkOrder { get; set; }
        public Service Service { get; set; }
        public LiftingBridge LiftingBridge { get; set; }
        public ICollection<InterventionSparePart> InterventionSpareParts { get; set; }
    }
}