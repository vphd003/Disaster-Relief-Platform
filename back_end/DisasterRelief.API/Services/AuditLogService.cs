using DisasterReliefAPI.Models;
using DisasterReliefAPI.Repositories;
using DisasterReliefAPI.Repositories.Interfaces;

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