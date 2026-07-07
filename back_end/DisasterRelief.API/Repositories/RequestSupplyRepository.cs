using DisasterReliefAPI.Data;
using DisasterReliefAPI.Models;
using DisasterReliefAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DisasterReliefAPI.Repositories
{
    public class RequestSupplyRepository
        : GenericRepository<RequestSupply>, IRequestSupplyRepository
    {
        public RequestSupplyRepository(AppDbContext context)
            : base(context)
        {
        }

        public async Task<IEnumerable<RequestSupply>> GetByRequestIdAsync(int requestId)
        {
            return await _context.RequestSupplies
                .Where(x => x.RequestId == requestId)
                .ToListAsync();
        }
    }
}