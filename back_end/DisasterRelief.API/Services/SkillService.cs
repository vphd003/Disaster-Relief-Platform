using DisasterReliefAPI.Models;
using DisasterReliefAPI.Repositories.Interfaces;

namespace DisasterReliefAPI.Services
{
    public class SkillService
        : BaseService<Skill>, ISkillService
    {
        private readonly ISkillRepository _repository;

        public SkillService(ISkillRepository repository)
            : base(repository)
        {
            _repository = repository;
        }

        public async Task<Skill?> GetByNameAsync(string skillName)
        {
            return await _repository.GetByNameAsync(skillName);
        }
    }
}