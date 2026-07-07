using DisasterReliefAPI.Models;
using DisasterReliefAPI.Repositories.Interfaces;

namespace DisasterReliefAPI.Services
{
    public class SupplyService
        : BaseService<Supply>, ISupplyService
    {
        private readonly ISupplyRepository _repository;

        public SupplyService(ISupplyRepository repository)
            : base(repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Supply>> GetByCategoryAsync(string category)
        {
            return await _repository.GetByCategoryAsync(category);
        }
    }
}