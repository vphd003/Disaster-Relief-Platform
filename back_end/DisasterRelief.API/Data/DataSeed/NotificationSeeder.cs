using DisasterReliefAPI.Data;
using DisasterReliefAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DisasterRelief.API.DataSeed;

public static class NotificationSeeder
{
    public static async Task SeedAsync(AppDbContext context)
    {
        if (await context.Notifications.AnyAsync())
            return;

        var notifications = new List<Notification>();

        int id = 1;

        foreach (var user in await context.Users.ToListAsync())
        {
            notifications.Add(new Notification
            {
                
                UserId = user.UserId,
                Title = "Welcome",
                Content = $"Welcome {user.FullName} to Disaster Relief System.",
                Type = "System",
                IsRead = true,
                CreatedAt = DateTime.UtcNow.AddDays(-30)
            });

            notifications.Add(new Notification
            {
                NotificationId = id++,
                UserId = user.UserId,
                Title = "New Update",
                Content = "System has been updated successfully.",
                Type = "Announcement",
                IsRead = false,
                CreatedAt = DateTime.UtcNow.AddDays(-5)
            });

            if (user.RoleId == 3)
            {
                notifications.Add(new Notification
                {
                    NotificationId = id++,
                    UserId = user.UserId,
                    Title = "New Assignment",
                    Content = "You have received a new relief assignment.",
                    Type = "Assignment",
                    IsRead = false,
                    CreatedAt = DateTime.UtcNow.AddDays(-1)
                });
            }

            if (user.RoleId == 4)
            {
                notifications.Add(new Notification
                {
                    NotificationId = id++,
                    UserId = user.UserId,
                    Title = "Request Status",
                    Content = "Your relief request is being processed.",
                    Type = "ReliefRequest",
                    IsRead = false,
                    CreatedAt = DateTime.UtcNow.AddHours(-12)
                });
            }
        }
        var duplicateIds = notifications
    .GroupBy(x => x.NotificationId)
    .Where(x => x.Count() > 1)
    .Select(x => x.Key)
    .ToList();


        if (duplicateIds.Any())
        {
            throw new Exception(
                $"Duplicate NotificationId: {string.Join(",", duplicateIds)}"
            );
        }
        await context.Notifications.AddRangeAsync(notifications);
        await context.SaveChangesAsync();
    }
}