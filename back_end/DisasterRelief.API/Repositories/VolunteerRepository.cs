using DisasterReliefAPI.Data;
using DisasterReliefAPI.Models;
using DisasterReliefAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DisasterReliefAPI.Repositories
{
    public class VolunteerRepository
        : GenericRepository<Volunteer>, IVolunteerRepository
    {
        public VolunteerRepository(AppDbContext context)
            : base(context)
        {
        }

        public async Task<IEnumerable<Volunteer>> GetApprovedAsync()
        {
            return await _context.Volunteers
                .Where(x => x.ApprovalStatus == 1)
                .ToListAsync();
        }

        public async Task<IEnumerable<Volunteer>> GetAvailableAsync()
        {
            return await _context.Volunteers
                .Where(x => x.AvailabilityStatus == 1)
                .ToListAsync();
        }
    }
}