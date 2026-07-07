using DisasterRelief.API.Data;
using DisasterReliefAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DisasterRelief.API.DataSeed;

public static class AssignmentSeeder
{
    public static async Task SeedAsync(AppDbContext context)
    {
        if (await context.Assignments.AnyAsync())
            return;

        var assignments = new List<Assignment>
        {
            new()
            {
                AssignmentId = 1,
                VolunteerId = 1,
                RequestId = 1,
                UserId = 2,
                AssignedAt = DateTime.UtcNow.AddDays(-8),
                Status = 2
            },

            new()
            {
                AssignmentId = 2,
                VolunteerId = 2,
                RequestId = 2,
                UserId = 2,
                AssignedAt = DateTime.UtcNow.AddDays(-7),
                Status = 1
            },

            new()
            {
                AssignmentId = 3,
                VolunteerId = 3,
                RequestId = 3,
                UserId = 2,
                AssignedAt = DateTime.UtcNow.AddDays(-6),
                Status = 1
            },

            new()
            {
                AssignmentId = 4,
                VolunteerId = 4,
                RequestId = 4,
                UserId = 3,
                AssignedAt = DateTime.UtcNow.AddDays(-5),
                Status = 0
            },

            new()
            {
                AssignmentId = 5,
                VolunteerId = 5,
                RequestId = 5,
                UserId = 3,
                AssignedAt = DateTime.UtcNow.AddDays(-5),
                Status = 2
            },

            new()
            {
                AssignmentId = 6,
                VolunteerId = 6,
                RequestId = 6,
                UserId = 3,
                AssignedAt = DateTime.UtcNow.AddDays(-4),
                Status = 1
            },

            new()
            {
                AssignmentId = 7,
                VolunteerId = 7,
                RequestId = 7,
                UserId = 2,
                AssignedAt = DateTime.UtcNow.AddDays(-3),
                Status = 0
            },

            new()
            {
                AssignmentId = 8,
                VolunteerId = 8,
                RequestId = 8,
                UserId = 2,
                AssignedAt = DateTime.UtcNow.AddDays(-2),
                Status = 0
            },

            new()
            {
                AssignmentId = 9,
                VolunteerId = 1,
                RequestId = 9,
                UserId = 3,
                AssignedAt = DateTime.UtcNow.AddDays(-2),
                Status = 1
            },

            new()
            {
                AssignmentId = 10,
                VolunteerId = 2,
                RequestId = 10,
                UserId = 3,
                AssignedAt = DateTime.UtcNow.AddDays(-1),
                Status = 0
            }
        };

        await context.Assignments.AddRangeAsync(assignments);
        await context.SaveChangesAsync();
    }
}