using DisasterReliefAPI.Data;
using DisasterReliefAPI.Models;
using DisasterReliefAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DisasterReliefAPI.Repositories
{
    public class SkillRepository
        : GenericRepository<Skill>, ISkillRepository
    {
        public SkillRepository(AppDbContext context)
            : base(context)
        {
        }

        public async Task<Skill?> GetByNameAsync(string skillName)
        {
            return await _context.Skills
                .FirstOrDefaultAsync(x => x.SkillName == skillName);
        }
    }
}