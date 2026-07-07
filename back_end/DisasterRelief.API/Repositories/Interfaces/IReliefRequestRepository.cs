using DisasterReliefAPI.Models;

namespace DisasterReliefAPI.Repositories.Interfaces
{
    public interface IReliefRequestRepository
        : IGenericRepository<ReliefRequest>
    {
        Task<IEnumerable<ReliefRequest>> GetByRequesterAsync(int requesterId);

        Task<IEnumerable<ReliefRequest>> GetByStatusAsync(byte status);
    }
}