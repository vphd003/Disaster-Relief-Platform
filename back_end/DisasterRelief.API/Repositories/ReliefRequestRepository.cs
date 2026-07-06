using DisasterReliefAPI.Data;
using DisasterReliefAPI.Models;
using DisasterReliefAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DisasterReliefAPI.Repositories
{
    public class ReliefRequestRepository
        : GenericRepository<ReliefRequest>, IReliefRequestRepository
    {
        public ReliefRequestRepository(AppDbContext context)
            : base(context)
        {
        }

        public async Task<IEnumerable<ReliefRequest>> GetByRequesterAsync(int requesterId)
        {
            return await _context.ReliefRequests
                .Where(r => r.RequesterId == requesterId)
                .ToListAsync();
        }

        public async Task<IEnumerable<ReliefRequest>> GetByStatusAsync(byte status)
        {
            return await _context.ReliefRequests
                .Where(r => r.Status == status)
                .ToListAsync();
        }
    }
}