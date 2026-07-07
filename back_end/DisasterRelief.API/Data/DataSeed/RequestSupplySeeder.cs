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
               
                RequestId = 1,
                SupplyId = 1,
                QuantityRequested = 500,
                Status = 0
            },

            new()
            {
                
                RequestId = 1,
                SupplyId = 2,
                QuantityRequested = 300,
                Status = 0
            },

            new()
            {
               
                RequestId = 2,
                SupplyId = 3,
                QuantityRequested = 100,
                Status = 1
            },

            new()
            {
               
                RequestId = 3,
                SupplyId = 4,
                QuantityRequested = 250,
                Status = 0
            },

            new()
            {
               
                RequestId = 4,
                SupplyId = 5,
                QuantityRequested = 150,
                Status = 1
            },

            new()
            {
               
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