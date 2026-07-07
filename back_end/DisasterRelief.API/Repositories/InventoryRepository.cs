using DisasterReliefAPI.Data;
using DisasterReliefAPI.Models;
using DisasterReliefAPI.Repositories.Interfaces;

namespace DisasterReliefAPI.Repositories
{
    public class InventoryRepository
        : GenericRepository<Inventory>, IInventoryRepository
    {
        public InventoryRepository(AppDbContext context)
            : base(context)
        {
        }
    }
}