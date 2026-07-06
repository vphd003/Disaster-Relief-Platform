using DisasterReliefAPI.Models;

namespace DisasterReliefAPI.Services
{
    public interface IUserService : IBaseService<User>
    {
        Task<User?> GetByEmailAsync(string email);

        Task<IEnumerable<User>> GetByRoleAsync(int roleId);
    }
}