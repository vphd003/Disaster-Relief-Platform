using DisasterReliefAPI.Data;
using DisasterReliefAPI.Models;
using DisasterReliefAPI.Repositories.Interfaces;

namespace DisasterReliefAPI.Repositories
{
    public class RefreshTokenRepository
        : GenericRepository<RefreshToken>, IRefreshTokenRepository
    {
        public RefreshTokenRepository(AppDbContext context)
            : base(context)
        {
        }
    }
}