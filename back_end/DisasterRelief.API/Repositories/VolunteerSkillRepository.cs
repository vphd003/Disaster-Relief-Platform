using DisasterReliefAPI.Data;
using DisasterReliefAPI.Models;
using DisasterReliefAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DisasterReliefAPI.Repositories
{
    public class VolunteerSkillRepository
        : GenericRepository<VolunteerSkill>, IVolunteerSkillRepository
    {
        public VolunteerSkillRepository(AppDbContext context)
            : base(context)
        {
        }

        public async Task<IEnumerable<VolunteerSkill>> GetByVolunteerAsync(int volunteerId)
        {
            return await _context.VolunteerSkills
                .Where(x => x.VolunteerId == volunteerId)
                .ToListAsync();
        }

        public async Task<IEnumerable<VolunteerSkill>> GetBySkillAsync(int skillId)
        {
            return await _context.VolunteerSkills
                .Where(x => x.SkillId == skillId)
                .ToListAsync();
        }
    }
}