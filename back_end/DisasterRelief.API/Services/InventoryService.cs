using DisasterReliefAPI.Models;
using DisasterReliefAPI.Repositories;

namespace DisasterReliefAPI.Services
{
    public class InventoryService
        : BaseService<Inventory>, IInventoryService
    {
        public InventoryService(IInventoryRepository repository)
            : base(repository)
        {
        }
    }
}