using DisasterReliefAPI.Data;
using DisasterReliefAPI.Models;
using DisasterReliefAPI.Repositories.Interfaces;

namespace DisasterReliefAPI.Repositories
{
    public class NotificationRepository
        : GenericRepository<Notification>, INotificationRepository
    {
        public NotificationRepository(AppDbContext context)
            : base(context)
        {
        }
    }
}