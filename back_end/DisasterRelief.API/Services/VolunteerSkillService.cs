using DisasterReliefAPI.Models;
using DisasterReliefAPI.Repositories.Interfaces;

namespace DisasterReliefAPI.Services
{
    public class VolunteerSkillService
        : BaseService<VolunteerSkill>, IVolunteerSkillService
    {
        private readonly IVolunteerSkillRepository _repository;

        public VolunteerSkillService(IVolunteerSkillRepository repository)
            : base(repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<VolunteerSkill>> GetByVolunteerAsync(int volunteerId)
        {
            return await _repository.GetByVolunteerAsync(volunteerId);
        }

        public async Task<IEnumerable<VolunteerSkill>> GetBySkillAsync(int skillId)
        {
            return await _repository.GetBySkillAsync(skillId);
        }
    }
}