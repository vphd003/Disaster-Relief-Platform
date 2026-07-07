using DisasterRelief.API.Data;
using DisasterReliefAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DisasterRelief.API.DataSeed;

public static class InventorySeeder
{
    public static async Task SeedAsync(AppDbContext context)
    {
        if (await context.Inventories.AnyAsync())
            return;

        var inventories = new List<Inventory>();

        int inventoryId = 1;
        var random = new Random();

        // 5 Warehouses x 20 Supplies = 100 Inventory records
        for (int warehouseId = 1; warehouseId <= 5; warehouseId++)
        {
            for (int supplyId = 1; supplyId <= 20; supplyId++)
            {
                inventories.Add(new Inventory
                {
                    InventoryId = inventoryId++,
                    WarehouseId = warehouseId,
                    SupplyId = supplyId,
                    Quantity = random.Next(100, 1000),
                    UpdatedAt = DateTime.UtcNow
                });
            }
        }

        await context.Inventories.AddRangeAsync(inventories);
        await context.SaveChangesAsync();
    }
}