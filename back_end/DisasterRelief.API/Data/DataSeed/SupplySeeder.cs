using DisasterReliefAPI.Data;
using DisasterReliefAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DisasterRelief.API.DataSeed;

public static class SupplySeeder
{
    public static async Task SeedAsync(AppDbContext context)
    {
        if (await context.Supplies.AnyAsync())
            return;

        var supplies = new List<Supply>
        {
            new()
            {
                SupplyId = 1,
                SupplyName = "Rice",
                Unit = "kg",
                Category = "Food"
            },

            new()
            {
                SupplyId = 2,
                SupplyName = "Instant Noodles",
                Unit = "box",
                Category = "Food"
            },

            new()
            {
                SupplyId = 3,
                SupplyName = "Drinking Water",
                Unit = "bottle",
                Category = "Water"
            },

            new()
            {
                SupplyId = 4,
                SupplyName = "Blanket",
                Unit = "piece",
                Category = "Shelter"
            },

            new()
            {
                SupplyId = 5,
                SupplyName = "Tent",
                Unit = "set",
                Category = "Shelter"
            },

            new()
            {
                SupplyId = 6,
                SupplyName = "First Aid Kit",
                Unit = "kit",
                Category = "Medical"
            },

            new()
            {
                SupplyId = 7,
                SupplyName = "Medical Mask",
                Unit = "box",
                Category = "Medical"
            },

            new()
            {
                SupplyId = 8,
                SupplyName = "Milk",
                Unit = "box",
                Category = "Food"
            },

            new()
            {
                SupplyId = 9,
                SupplyName = "Baby Food",
                Unit = "box",
                Category = "Food"
            },

            new()
            {
                SupplyId = 10,
                SupplyName = "Flashlight",
                Unit = "piece",
                Category = "Equipment"
            },

            new()
            {
                SupplyId = 11,
                SupplyName = "Battery",
                Unit = "pack",
                Category = "Equipment"
            },

            new()
            {
                SupplyId = 12,
                SupplyName = "Raincoat",
                Unit = "piece",
                Category = "Equipment"
            },

            new()
            {
                SupplyId = 13,
                SupplyName = "Life Jacket",
                Unit = "piece",
                Category = "Safety"
            },

            new()
            {
                SupplyId = 14,
                SupplyName = "Rope",
                Unit = "meter",
                Category = "Safety"
            },

            new()
            {
                SupplyId = 15,
                SupplyName = "Hygiene Kit",
                Unit = "kit",
                Category = "Hygiene"
            },

            new()
            {
                SupplyId = 16,
                SupplyName = "Soap",
                Unit = "bar",
                Category = "Hygiene"
            },

            new()
            {
                SupplyId = 17,
                SupplyName = "Toothbrush",
                Unit = "piece",
                Category = "Hygiene"
            },

            new()
            {
                SupplyId = 18,
                SupplyName = "Towel",
                Unit = "piece",
                Category = "Hygiene"
            },

            new()
            {
                SupplyId = 19,
                SupplyName = "Cooking Oil",
                Unit = "bottle",
                Category = "Food"
            },

            new()
            {
                SupplyId = 20,
                SupplyName = "Canned Food",
                Unit = "can",
                Category = "Food"
            }
        };

        await context.Supplies.AddRangeAsync(supplies);
        await context.SaveChangesAsync();
    }
}