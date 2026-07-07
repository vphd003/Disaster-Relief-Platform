using DisasterReliefAPI.Models;
using DisasterReliefAPI.Repositories;
using DisasterReliefAPI.Repositories.Interfaces;

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