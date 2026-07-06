using DisasterReliefAPI.Models;
using DisasterReliefAPI.Repositories;

namespace DisasterReliefAPI.Services
{
    public class InventoryTransactionService
        : BaseService<InventoryTransaction>, IInventoryTransactionService
    {
        public InventoryTransactionService(IInventoryTransactionRepository repository)
            : base(repository)
        {
        }
    }
}