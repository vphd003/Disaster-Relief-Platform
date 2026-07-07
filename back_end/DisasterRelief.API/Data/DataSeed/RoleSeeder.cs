using DisasterReliefAPI.Data;
using DisasterReliefAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DisasterRelief.API.DataSeed;

public static class RoleSeeder
{
    public static async Task SeedAsync(AppDbContext context)
    {
        if (await context.Roles.AnyAsync())
            return;

        var roles = new List<Role>
        {
            new()
            {
                RoleId = 1,
                RoleName = "Admin",
                Description = "System Administrator"
            },
            new()
            {
                RoleId = 2,
                RoleName = "Coordinator",
                Description = "Manage requests and volunteers"
            },
            new()
            {
                RoleId = 3,
                RoleName = "Volunteer",
                Description = "Participate in relief activities"
            },
            new()
            {
                RoleId = 4,
                RoleName = "Requester",
                Description = "Create relief requests"
            }
        };

        await context.Roles.AddRangeAsync(roles);
        await context.SaveChangesAsync();
    }
}