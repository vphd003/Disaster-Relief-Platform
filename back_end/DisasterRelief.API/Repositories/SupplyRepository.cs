using DisasterReliefAPI.Data;
using DisasterReliefAPI.Models;
using DisasterReliefAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DisasterReliefAPI.Repositories
{
    public class SupplyRepository
        : GenericRepository<Supply>, ISupplyRepository
    {
        public SupplyRepository(AppDbContext context)
            : base(context)
        {
        }

        public async Task<IEnumerable<Supply>> GetByCategoryAsync(string category)
        {
            return await _context.Supplies
                .Where(x => x.Category == category)
                .ToListAsync();
        }
    }
}