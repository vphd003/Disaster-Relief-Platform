
using DisasterRelief.API.DataSeed;
using DisasterRelief.API.Helpers;
using DisasterReliefAPI.Data;
using DisasterReliefAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DisasterRelief.API.Data.DataSeed;

public static class DbSeeder
{
    public static async Task SeedAsync(AppDbContext context)
    {
        await RoleSeeder.SeedAsync(context);
        await UserSeeder.SeedAsync(context);
        await VolunteerSeeder.SeedAsync(context);
        await RequesterSeeder.SeedAsync(context);

        await SkillSeeder.SeedAsync(context);
        await VolunteerSkillSeeder.SeedAsync(context);

        await SupplySeeder.SeedAsync(context);

        await ReliefRequestSeeder.SeedAsync(context);
        await RequestSupplySeeder.SeedAsync(context);

        await WarehouseSeeder.SeedAsync(context);
        await InventorySeeder.SeedAsync(context);
        await InventoryTransactionSeeder.SeedAsync(context);

        await AssignmentSeeder.SeedAsync(context);
        await NotificationSeeder.SeedAsync(context);
        await RefreshTokenSeeder.SeedAsync(context);
        await AuditLogSeeder.SeedAsync(context);
    }
}