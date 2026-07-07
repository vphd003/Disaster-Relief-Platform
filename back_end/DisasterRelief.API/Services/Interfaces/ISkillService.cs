using DisasterReliefAPI.Models;

namespace DisasterReliefAPI.Services
{
    public interface ISkillService : IBaseService<Skill>
    {
        Task<Skill?> GetByNameAsync(string skillName);
    }
}