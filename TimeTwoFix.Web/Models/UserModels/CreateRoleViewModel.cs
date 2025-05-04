namespace TimeTwoFix.Web.Models.UserModels
{
    public class CreateRoleViewModel
    {
        public string RoleName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; } = true;

    }
}
