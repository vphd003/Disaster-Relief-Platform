using DisasterReliefAPI.Models;
using DisasterReliefAPI.Repositories.Interfaces;

namespace DisasterReliefAPI.Services
{
    public class ReliefRequestService
        : BaseService<ReliefRequest>, IReliefRequestService
    {
        private readonly IReliefRequestRepository _repository;

        public ReliefRequestService(IReliefRequestRepository repository)
            : base(repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ReliefRequest>> GetByRequesterAsync(int requesterId)
        {
            return await _repository.GetByRequesterAsync(requesterId);
        }

        public async Task<IEnumerable<ReliefRequest>> GetByStatusAsync(byte status)
        {
            return await _repository.GetByStatusAsync(status);
        }
    }
}