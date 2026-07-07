using DisasterReliefAPI.Models;

namespace DisasterReliefAPI.Repositories.Interfaces
{
    public interface IVolunteerSkillRepository
        : IGenericRepository<VolunteerSkill>
    {
        Task<IEnumerable<VolunteerSkill>> GetByVolunteerAsync(int volunteerId);

        Task<IEnumerable<VolunteerSkill>> GetBySkillAsync(int skillId);
    }
}