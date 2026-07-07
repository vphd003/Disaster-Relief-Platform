using DisasterReliefAPI.Data;
using DisasterReliefAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DisasterRelief.API.DataSeed;

public static class RequestSupplySeeder
{
    public static async Task SeedAsync(AppDbContext context)
    {
        if (await context.RequestSupplies.AnyAsync())
            return;

        var requestSupplies = new List<RequestSupply>
        {
            new()
            {
                RequestSupplyId = 1,
                RequestId = 1,
                SupplyId = 1,
                QuantityRequested = 500,
                Status = 0
            },

            new()
            {
                RequestSupplyId = 2,
                RequestId = 1,
                SupplyId = 2,
                QuantityRequested = 300,
                Status = 0
            },

            new()
            {
                RequestSupplyId = 3,
                RequestId = 2,
                SupplyId = 3,
                QuantityRequested = 100,
                Status = 1
            },

            new()
            {
                RequestSupplyId = 4,
                RequestId = 3,
                SupplyId = 4,
                QuantityRequested = 250,
                Status = 0
            },

            new()
            {
                RequestSupplyId = 5,
                RequestId = 4,
                SupplyId = 5,
                QuantityRequested = 150,
                Status = 1
            },

            new()
            {
                RequestSupplyId = 6,
                RequestId = 5,
                SupplyId = 2,
                QuantityRequested = 600,
                Status = 2
            }
        };

        await context.RequestSupplies.AddRangeAsync(requestSupplies);
        await context.SaveChangesAsync();
    }
}