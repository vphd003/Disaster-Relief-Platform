using DisasterReliefAPI.Models;

namespace DisasterReliefAPI.Services
{
    public interface IReliefRequestService : IBaseService<ReliefRequest>
    {
        Task<IEnumerable<ReliefRequest>> GetByRequesterAsync(int requesterId);

        Task<IEnumerable<ReliefRequest>> GetByStatusAsync(byte status);
    }
}