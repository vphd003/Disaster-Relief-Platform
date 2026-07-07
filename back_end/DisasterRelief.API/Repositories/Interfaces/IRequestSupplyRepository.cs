using DisasterReliefAPI.Models;

namespace DisasterReliefAPI.Repositories.Interfaces
{
    public interface IRequestSupplyRepository
        : IGenericRepository<RequestSupply>
    {
        Task<IEnumerable<RequestSupply>> GetByRequestIdAsync(int requestId);
    }
}