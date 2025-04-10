using TimeTwoFix.Core.Entities.SkillsManagement;
using TimeTwoFix.Core.Interfaces.Repositories.Base;

namespace TimeTwoFix.Core.Interfaces.Repositories
{
    public interface ISkillRepository : IBaseRepository<Skill>
    {
        Task<IEnumerable<Skill>> GetSkillsByNameAsync(string name);
    }
}
