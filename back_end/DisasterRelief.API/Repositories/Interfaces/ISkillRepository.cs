using DisasterReliefAPI.Models;

namespace DisasterReliefAPI.Repositories.Interfaces
{
    public interface ISkillRepository
        : IGenericRepository<Skill>
    {
        Task<Skill?> GetByNameAsync(string skillName);
    }
}