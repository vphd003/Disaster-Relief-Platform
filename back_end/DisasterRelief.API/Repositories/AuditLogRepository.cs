using DisasterReliefAPI.Data;
using DisasterReliefAPI.Models;
using DisasterReliefAPI.Repositories.Interfaces;

namespace DisasterReliefAPI.Repositories
{
    public class AuditLogRepository
        : GenericRepository<AuditLog>, IAuditLogRepository
    {
        public AuditLogRepository(AppDbContext context)
            : base(context)
        {
        }
    }
}