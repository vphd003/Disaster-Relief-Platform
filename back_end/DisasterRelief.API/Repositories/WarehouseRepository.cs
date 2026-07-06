using DisasterReliefAPI.Data;
using DisasterReliefAPI.Models;
using DisasterReliefAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DisasterReliefAPI.Repositories
{
    public class WarehouseRepository
        : GenericRepository<Warehouse>, IWarehouseRepository
    {
        public WarehouseRepository(AppDbContext context)
            : base(context)
        {
        }

        public async Task<IEnumerable<Warehouse>> GetAvailableAsync()
        {
            return await _context.Warehouses
                .Where(x => x.Capacity > 0)
                .ToListAsync();
        }
    }
}