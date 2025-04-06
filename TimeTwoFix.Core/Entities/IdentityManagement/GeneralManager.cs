namespace TimeTwoFix.Core.Entities.IdentityManagement
{
    public class GeneralManager : ApplicationUser
    {
        public string? OfficeNumber { get; set; }
        public int YearsInManagement { get; set; }
    }
}