using DisasterReliefAPI.Models;
using DisasterReliefAPI.Repositories;
using DisasterReliefAPI.Repositories.Interfaces;

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