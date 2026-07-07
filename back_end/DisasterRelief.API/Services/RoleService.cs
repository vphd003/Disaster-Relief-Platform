using DisasterReliefAPI.Models;
using DisasterReliefAPI.Repositories.Interfaces;

namespace DisasterReliefAPI.Services
{
    public class RoleService
        : BaseService<Role>, IRoleService
    {
        private readonly IRoleRepository _repository;

        public RoleService(IRoleRepository repository)
            : base(repository)
        {
            _repository = repository;
        }

        public async Task<Role?> GetByNameAsync(string roleName)
        {
            return await _repository.GetByNameAsync(roleName);
        }
    }
}