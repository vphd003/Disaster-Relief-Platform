using DisasterReliefAPI.Models;

namespace DisasterReliefAPI.Services
{
    public interface IVolunteerSkillService : IBaseService<VolunteerSkill>
    {
        Task<IEnumerable<VolunteerSkill>> GetByVolunteerAsync(int volunteerId);

        Task<IEnumerable<VolunteerSkill>> GetBySkillAsync(int skillId);
    }
}