using DisasterRelief.API.Data;
using DisasterReliefAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DisasterRelief.API.DataSeed;

public static class VolunteerSeeder
{
    public static async Task SeedAsync(AppDbContext context)
    {
        if (await context.Volunteers.AnyAsync())
            return;

        var volunteers = new List<Volunteer>
        {
            new()
            {
                VolunteerId = 1,
                UserId = 4,
                Experience = "3 years in flood relief and emergency logistics.",
                AvailabilityStatus = 1,
                ApprovalStatus = 1,
                ApprovedBy = 1,
                ApprovedAt = DateTime.UtcNow.AddDays(-30),
                UpdatedAt = DateTime.UtcNow
            },
            new()
            {
                VolunteerId = 2,
                UserId = 5,
                Experience = "First aid volunteer.",
                AvailabilityStatus = 1,
                ApprovalStatus = 1,
                ApprovedBy = 1,
                ApprovedAt = DateTime.UtcNow.AddDays(-28),
                UpdatedAt = DateTime.UtcNow
            },
            new()
            {
                VolunteerId = 3,
                UserId = 6,
                Experience = "Food distribution experience.",
                AvailabilityStatus = 1,
                ApprovalStatus = 1,
                ApprovedBy = 1,
                ApprovedAt = DateTime.UtcNow.AddDays(-20),
                UpdatedAt = DateTime.UtcNow
            },
            new()
            {
                VolunteerId = 4,
                UserId = 7,
                Experience = "Medical support volunteer.",
                AvailabilityStatus = 1,
                ApprovalStatus = 1,
                ApprovedBy = 1,
                ApprovedAt = DateTime.UtcNow.AddDays(-15),
                UpdatedAt = DateTime.UtcNow
            },
            new()
            {
                VolunteerId = 5,
                UserId = 8,
                Experience = "Rescue support in mountainous areas.",
                AvailabilityStatus = 0,
                ApprovalStatus = 1,
                ApprovedBy = 1,
                ApprovedAt = DateTime.UtcNow.AddDays(-12),
                UpdatedAt = DateTime.UtcNow
            },
            new()
            {
                VolunteerId = 6,
                UserId = 9,
                Experience = "Transportation and logistics.",
                AvailabilityStatus = 1,
                ApprovalStatus = 1,
                ApprovedBy = 1,
                ApprovedAt = DateTime.UtcNow.AddDays(-10),
                UpdatedAt = DateTime.UtcNow
            },
            new()
            {
                VolunteerId = 7,
                UserId = 10,
                Experience = "Community emergency response.",
                AvailabilityStatus = 1,
                ApprovalStatus = 1,
                ApprovedBy = 1,
                ApprovedAt = DateTime.UtcNow.AddDays(-8),
                UpdatedAt = DateTime.UtcNow
            },
            new()
            {
                VolunteerId = 8,
                UserId = 11,
                Experience = "New volunteer.",
                AvailabilityStatus = 1,
                ApprovalStatus = 0,
                ApprovedBy = null,
                ApprovedAt = null,
                UpdatedAt = DateTime.UtcNow
            }
        };

        await context.Volunteers.AddRangeAsync(volunteers);
        await context.SaveChangesAsync();
    }
}