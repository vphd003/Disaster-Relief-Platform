using DisasterRelief.API.Data;
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
                RequesterId = 1,
                UserId = 12
            },
            new()
            {
                RequesterId = 2,
                UserId = 13
            },
            new()
            {
                RequesterId = 3,
                UserId = 14
            },
            new()
            {
                RequesterId = 4,
                UserId = 15
            },
            new()
            {
                RequesterId = 5,
                UserId = 16
            },
            new()
            {
                RequesterId = 6,
                UserId = 17
            },
            new()
            {
                RequesterId = 7,
                UserId = 18
            },
            new()
            {
                RequesterId = 8,
                UserId = 19
            },
            new()
            {
                RequesterId = 9,
                UserId = 20
            },
            new()
            {
                RequesterId = 10,
                UserId = 21
            }
        };

        await context.Requesters.AddRangeAsync(requesters);
        await context.SaveChangesAsync();
    }
}