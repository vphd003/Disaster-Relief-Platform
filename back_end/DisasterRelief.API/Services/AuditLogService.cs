using DisasterReliefAPI.Models;
using DisasterReliefAPI.Repositories;

namespace DisasterReliefAPI.Services
{
    public class AuditLogService
        : BaseService<AuditLog>, IAuditLogService
    {
        public AuditLogService(IAuditLogRepository repository)
            : base(repository)
        {
        }
    }
}