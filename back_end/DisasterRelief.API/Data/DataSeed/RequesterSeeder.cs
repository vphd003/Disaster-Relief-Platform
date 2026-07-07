using DisasterReliefAPI.Data;
using DisasterReliefAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DisasterRelief.API.DataSeed;

public static class RequesterSeeder
{
    public static async Task SeedAsync(AppDbContext context)
    {
        if (await context.Requesters.AnyAsync())
            return;

        var requesters = new List<Requester>
        {
            new()
            {
                
                UserId = 12
            },
            new()
            {
                
                UserId = 13
            },
            new()
            {
               
                UserId = 14
            },
            new()
            {
               
                UserId = 15
            },
            new()
            {
                
                UserId = 16
            },
            new()
            {
               
                UserId = 17
            },
            new()
            {
               
                UserId = 18
            },
            new()
            {
                
                UserId = 19
            },
            new()
            {
               
                UserId = 20
            },
            new()
            {
                
                UserId = 21
            }
        };

        await context.Requesters.AddRangeAsync(requesters);
        await context.SaveChangesAsync();
    }
}