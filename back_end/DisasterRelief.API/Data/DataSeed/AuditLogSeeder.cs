using DisasterRelief.API.Data;
using DisasterReliefAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DisasterRelief.API.DataSeed;

public static class AuditLogSeeder
{
    public static async Task SeedAsync(AppDbContext context)
    {
        if (await context.AuditLogs.AnyAsync())
            return;

        var auditLogs = new List<AuditLog>();

        int auditId = 1;

        // ===== Admin =====
        auditLogs.Add(new AuditLog
        {
            AuditId = auditId++,
            UserId = 1,
            Action = "Create",
            Entity = "Role",
            EntityId = 1,
            CreatedAt = DateTime.UtcNow.AddDays(-30)
        });

        auditLogs.Add(new AuditLog
        {
            AuditId = auditId++,
            UserId = 1,
            Action = "Create",
            Entity = "User",
            EntityId = 1,
            CreatedAt = DateTime.UtcNow.AddDays(-29)
        });

        // ===== Coordinator =====
        foreach (var requestId in Enumerable.Range(1, 10))
        {
            auditLogs.Add(new AuditLog
            {
                AuditId = auditId++,
                UserId = 2,
                Action = "Assign Volunteer",
                Entity = "Assignment",
                EntityId = requestId,
                CreatedAt = DateTime.UtcNow.AddDays(-requestId)
            });
        }

        foreach (var requestId in Enumerable.Range(11, 10))
        {
            auditLogs.Add(new AuditLog
            {
                AuditId = auditId++,
                UserId = 3,
                Action = "Approve Request",
                Entity = "ReliefRequest",
                EntityId = requestId,
                CreatedAt = DateTime.UtcNow.AddDays(-(requestId - 10))
            });
        }

        // ===== Volunteer =====
        foreach (var volunteerId in Enumerable.Range(4, 8))
        {
            auditLogs.Add(new AuditLog
            {
                AuditId = auditId++,
                UserId = volunteerId,
                Action = "Update Profile",
                Entity = "Volunteer",
                EntityId = volunteerId - 3,
                CreatedAt = DateTime.UtcNow.AddHours(-volunteerId)
            });
        }

        // ===== Requester =====
        for (int i = 12; i <= 21; i++)
        {
            auditLogs.Add(new AuditLog
            {
                AuditId = auditId++,
                UserId = i,
                Action = "Create Request",
                Entity = "ReliefRequest",
                EntityId = i - 11,
                CreatedAt = DateTime.UtcNow.AddHours(-(i * 2))
            });
        }

        await context.AuditLogs.AddRangeAsync(auditLogs);
        await context.SaveChangesAsync();
    }
}