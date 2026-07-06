using DisasterReliefAPI.Models;

namespace DisasterReliefAPI.Repositories.Interfaces
{
    public interface ISupplyRepository
        : IGenericRepository<Supply>
    {
        Task<IEnumerable<Supply>> GetByCategoryAsync(string category);
    }
}