using DisasterReliefAPI.Models;

namespace DisasterReliefAPI.Repositories.Interfaces
{
    public interface IRoleRepository
        : IGenericRepository<Role>
    {
        Task<Role?> GetByNameAsync(string roleName);
    }
}