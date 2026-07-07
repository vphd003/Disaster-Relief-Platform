using DisasterReliefAPI.Models;
using DisasterReliefAPI.Repositories.Interfaces;

namespace DisasterReliefAPI.Services
{
    public class RequestSupplyService
        : BaseService<RequestSupply>, IRequestSupplyService
    {
        private readonly IRequestSupplyRepository _repository;

        public RequestSupplyService(IRequestSupplyRepository repository)
            : base(repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<RequestSupply>> GetByRequestIdAsync(int requestId)
        {
            return await _repository.GetByRequestIdAsync(requestId);
        }
    }
}