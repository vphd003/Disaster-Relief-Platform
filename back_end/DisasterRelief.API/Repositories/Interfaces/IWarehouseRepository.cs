using DisasterReliefAPI.Models;

namespace DisasterReliefAPI.Repositories.Interfaces
{
    public interface IWarehouseRepository
        : IGenericRepository<Warehouse>
    {
        Task<IEnumerable<Warehouse>> GetAvailableAsync();
    }
}