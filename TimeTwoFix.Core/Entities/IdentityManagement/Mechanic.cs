using System.ComponentModel.DataAnnotations;
using TimeTwoFix.Core.Entities.WorkOrderManagement;

namespace TimeTwoFix.Core.Entities.IdentityManagement
{
    public class Mechanic : ApplicationUser
    {
        [MaxLength(50)]
        public string? Specialization { get; set; }

        public string? ToolBoxNumber { get; set; }

        public ICollection<Intervention> Interventions { get; set; }
    }
}