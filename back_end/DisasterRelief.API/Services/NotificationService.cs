using DisasterReliefAPI.Models;
using DisasterReliefAPI.Repositories.Interfaces;

namespace DisasterReliefAPI.Services
{
    public class NotificationService
        : BaseService<Notification>, INotificationService
    {
        public NotificationService(INotificationRepository repository)
            : base(repository)
        {
        }
    }
}