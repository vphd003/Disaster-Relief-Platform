using DisasterReliefAPI.Data;
using DisasterReliefAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DisasterRelief.API.DataSeed;

public static class InventoryTransactionSeeder
{
    public static async Task SeedAsync(AppDbContext context)
    {
        if (await context.InventoryTransactions.AnyAsync())
            return;

        var transactions = new List<InventoryTransaction>();

        int transactionId = 1;
        var random = new Random();

        // Mỗi Inventory có 2 giao dịch
        foreach (var inventory in await context.Inventories.ToListAsync())
        {
            // ===== IMPORT =====
            transactions.Add(new InventoryTransaction
            {
                TransactionId = transactionId++,
                InventoryId = inventory.InventoryId,
                Type = 1, // Import
                Quantity = random.Next(100, 500),
                ReferenceId = 0,
                CreatedAt = DateTime.UtcNow.AddDays(-random.Next(15, 60))
            });

            // ===== EXPORT =====
            transactions.Add(new InventoryTransaction
            {
                TransactionId = transactionId++,
                InventoryId = inventory.InventoryId,
                Type = 2, // Export
                Quantity = random.Next(10, 80),
                ReferenceId = random.Next(1, 21), // ReliefRequest giả định
                CreatedAt = DateTime.UtcNow.AddDays(-random.Next(1, 14))
            });
        }

        await context.InventoryTransactions.AddRangeAsync(transactions);
        await context.SaveChangesAsync();
    }
}