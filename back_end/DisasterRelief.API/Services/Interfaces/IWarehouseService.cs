using DisasterReliefAPI.Models;

namespace DisasterReliefAPI.Services
{
    public interface IWarehouseService : IBaseService<Warehouse>
    {
        Task<IEnumerable<Warehouse>> GetAvailableAsync();
    }
}