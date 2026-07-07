using DisasterReliefAPI.Data;

using DisasterReliefAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DisasterRelief.API.DataSeed;

public static class ReliefRequestSeeder
{
    public static async Task SeedAsync(AppDbContext context)
    {
        if (await context.ReliefRequests.AnyAsync())
            return;

        var requests = new List<ReliefRequest>
        {
            new()
            {
               
                RequesterId = 1,
                Title = "Flood Relief Support",
                Description = "Need drinking water and food supplies.",
                Priority = "High",
                Status = 0,
                Location = "Da Nang",
                Latitude = 16.0544m,
                Longitude = 108.2022m,
                CreatedAt = DateTime.UtcNow
            },

            new()
            {
                
                RequesterId = 2,
                Title = "Medical Assistance",
                Description = "Need emergency medicine and first aid kits.",
                Priority = "Critical",
                Status = 1,
                Location = "Hue",
                Latitude = 16.4637m,
                Longitude = 107.5909m,
                CreatedAt = DateTime.UtcNow
            },

            new()
            {
                
                RequesterId = 3,
                Title = "Food Distribution",
                Description = "Need rice and instant noodles.",
                Priority = "Medium",
                Status = 0,
                Location = "Quang Nam",
                Latitude = 15.5394m,
                Longitude = 108.0191m,
                CreatedAt = DateTime.UtcNow
            },

            new()
            {
                
                RequesterId = 4,
                Title = "Temporary Shelter",
                Description = "Need tents and blankets.",
                Priority = "High",
                Status = 1,
                Location = "Quang Tri",
                Latitude = 16.7403m,
                Longitude = 107.1855m,
                CreatedAt = DateTime.UtcNow
            },

            new()
            {
               
                RequesterId = 5,
                Title = "Clean Water",
                Description = "Need bottled water urgently.",
                Priority = "Critical",
                Status = 2,
                Location = "Quang Binh",
                Latitude = 17.4689m,
                Longitude = 106.6223m,
                CreatedAt = DateTime.UtcNow
            }
        };

        await context.ReliefRequests.AddRangeAsync(requests);
        await context.SaveChangesAsync();
    }
}