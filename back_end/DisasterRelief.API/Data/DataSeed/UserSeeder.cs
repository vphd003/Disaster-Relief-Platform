using DisasterReliefAPI.Data;
using DisasterReliefAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DisasterRelief.API.DataSeed;

public static class UserSeeder
{
    public static async Task SeedAsync(AppDbContext context)
    {
        if (await context.Users.AnyAsync())
            return;

        var hasher = new PasswordHasher<User>();

        var users = new List<User>();

        // ==========================
        // Admin
        // ==========================

        var admin = new User
        {
            UserId = 1,
            RoleId = 1,
            FullName = "System Administrator",
            Email = "admin@relief.com",
            Phone = "0900000001",
            Address = "Ha Noi",
            Status = 1,
            CreatedAt = DateTime.UtcNow
        };

        admin.PasswordHash = hasher.HashPassword(admin, "Admin@123");

        users.Add(admin);

        // ==========================
        // Coordinators
        // ==========================

        for (int i = 2; i <= 3; i++)
        {
            var coordinator = new User
            {
                UserId = i,
                RoleId = 2,
                FullName = $"Coordinator {i - 1}",
                Email = $"coordinator{i - 1}@relief.com",
                Phone = $"090000000{i}",
                Address = "Ha Noi",
                Status = 1,
                CreatedAt = DateTime.UtcNow
            };

            coordinator.PasswordHash =
                hasher.HashPassword(coordinator, "Coordinator@123");

            users.Add(coordinator);
        }

        // ==========================
        // Volunteers
        // ==========================

        for (int i = 4; i <= 11; i++)
        {
            var volunteer = new User
            {
                UserId = i,
                RoleId = 3,
                FullName = $"Volunteer {i - 3}",
                Email = $"volunteer{i - 3}@relief.com",
                Phone = $"09100000{i:00}",
                Address = "Ha Noi",
                Status = 1,
                CreatedAt = DateTime.UtcNow
            };

            volunteer.PasswordHash =
                hasher.HashPassword(volunteer, "Volunteer@123");

            users.Add(volunteer);
        }

        // ==========================
        // Requesters
        // ==========================

        for (int i = 12; i <= 21; i++)
        {
            var requester = new User
            {
                UserId = i,
                RoleId = 4,
                FullName = $"Requester {i - 11}",
                Email = $"requester{i - 11}@relief.com",
                Phone = $"09200000{i:00}",
                Address = "Ha Noi",
                Status = 1,
                CreatedAt = DateTime.UtcNow
            };

            requester.PasswordHash =
                hasher.HashPassword(requester, "Requester@123");

            users.Add(requester);
        }

        await context.Users.AddRangeAsync(users);
        await context.SaveChangesAsync();
    }
}