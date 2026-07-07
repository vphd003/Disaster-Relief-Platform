using DisasterReliefAPI.Data;
using DisasterReliefAPI.Models;
using DisasterReliefAPI.Repositories.Interfaces;

namespace DisasterReliefAPI.Repositories
{
    public class InventoryTransactionRepository
        : GenericRepository<InventoryTransaction>, IInventoryTransactionRepository
    {
        public InventoryTransactionRepository(AppDbContext context)
            : base(context)
        {
        }
    }
}