using DisasterReliefAPI.Data;
using DisasterReliefAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DisasterRelief.API.DataSeed;

public static class WarehouseSeeder
{
    public static async Task SeedAsync(AppDbContext context)
    {
        if (await context.Warehouses.AnyAsync())
            return;

        var warehouses = new List<Warehouse>
        {
            new()
            {
                WarehouseId = 1,
                WarehouseName = "Ha Noi Central Warehouse",
                Location = "Cau Giay, Ha Noi",
                Capacity = 5000,
                UpdatedAt = DateTime.UtcNow
            },

            new()
            {
                WarehouseId = 2,
                WarehouseName = "Da Nang Relief Warehouse",
                Location = "Hai Chau, Da Nang",
                Capacity = 3500,
                UpdatedAt = DateTime.UtcNow
            },

            new()
            {
                WarehouseId = 3,
                WarehouseName = "Ho Chi Minh Warehouse",
                Location = "Thu Duc, Ho Chi Minh City",
                Capacity = 7000,
                UpdatedAt = DateTime.UtcNow
            },

            new()
            {
                WarehouseId = 4,
                WarehouseName = "Can Tho Regional Warehouse",
                Location = "Ninh Kieu, Can Tho",
                Capacity = 2500,
                UpdatedAt = DateTime.UtcNow
            },

            new()
            {
                WarehouseId = 5,
                WarehouseName = "Hue Emergency Warehouse",
                Location = "Hue City",
                Capacity = 3000,
                UpdatedAt = DateTime.UtcNow
            }
        };

        await context.Warehouses.AddRangeAsync(warehouses);
        await context.SaveChangesAsync();
    }
}