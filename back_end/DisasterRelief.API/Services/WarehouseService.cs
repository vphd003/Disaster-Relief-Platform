using DisasterReliefAPI.Models;
using DisasterReliefAPI.Repositories.Interfaces;

namespace DisasterReliefAPI.Services
{
    public class WarehouseService
        : BaseService<Warehouse>, IWarehouseService
    {
        private readonly IWarehouseRepository _repository;

        public WarehouseService(IWarehouseRepository repository)
            : base(repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Warehouse>> GetAvailableAsync()
        {
            return await _repository.GetAvailableAsync();
        }
    }
}