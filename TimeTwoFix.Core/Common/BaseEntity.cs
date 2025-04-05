using System.ComponentModel.DataAnnotations;

namespace TimeTwoFix.Core.Common
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        [MaxLength(255)]
        public string? Notes { get; set; }

        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}