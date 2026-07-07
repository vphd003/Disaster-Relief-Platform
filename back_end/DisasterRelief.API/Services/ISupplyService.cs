using DisasterReliefAPI.Models;

namespace DisasterReliefAPI.Services
{
    public interface ISupplyService : IBaseService<Supply>
    {
        Task<IEnumerable<Supply>> GetByCategoryAsync(string category);
    }
}