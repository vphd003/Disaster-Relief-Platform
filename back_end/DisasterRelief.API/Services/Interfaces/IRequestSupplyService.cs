using DisasterReliefAPI.Models;

namespace DisasterReliefAPI.Services
{
    public interface IRequestSupplyService : IBaseService<RequestSupply>
    {
        Task<IEnumerable<RequestSupply>> GetByRequestIdAsync(int requestId);
    }
}