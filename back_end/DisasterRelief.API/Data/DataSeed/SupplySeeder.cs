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
               
                SupplyName = "Rice",
                Unit = "kg",
                Category = "Food"
            },

            new()
            {
               
                SupplyName = "Instant Noodles",
                Unit = "box",
                Category = "Food"
            },

            new()
            {
               
                SupplyName = "Drinking Water",
                Unit = "bottle",
                Category = "Water"
            },

            new()
            {
               
                SupplyName = "Blanket",
                Unit = "piece",
                Category = "Shelter"
            },

            new()
            {
               
                SupplyName = "Tent",
                Unit = "set",
                Category = "Shelter"
            },

            new()
            {
               
                SupplyName = "First Aid Kit",
                Unit = "kit",
                Category = "Medical"
            },

            new()
            {
              
                SupplyName = "Medical Mask",
                Unit = "box",
                Category = "Medical"
            },

            new()
            {
                
                SupplyName = "Milk",
                Unit = "box",
                Category = "Food"
            },

            new()
            {
               
                SupplyName = "Baby Food",
                Unit = "box",
                Category = "Food"
            },

            new()
            {
                
                SupplyName = "Flashlight",
                Unit = "piece",
                Category = "Equipment"
            },

            new()
            {
               
                SupplyName = "Battery",
                Unit = "pack",
                Category = "Equipment"
            },

            new()
            {
                
                SupplyName = "Raincoat",
                Unit = "piece",
                Category = "Equipment"
            },

            new()
            {
               
                SupplyName = "Life Jacket",
                Unit = "piece",
                Category = "Safety"
            },

            new()
            {
               
                SupplyName = "Rope",
                Unit = "meter",
                Category = "Safety"
            },

            new()
            {
               
                SupplyName = "Hygiene Kit",
                Unit = "kit",
                Category = "Hygiene"
            },

            new()
            {
               
                SupplyName = "Soap",
                Unit = "bar",
                Category = "Hygiene"
            },

            new()
            {
               
                SupplyName = "Toothbrush",
                Unit = "piece",
                Category = "Hygiene"
            },

            new()
            {
              
                SupplyName = "Towel",
                Unit = "piece",
                Category = "Hygiene"
            },

            new()
            {
               
                SupplyName = "Cooking Oil",
                Unit = "bottle",
                Category = "Food"
            },

            new()
            {
               
                SupplyName = "Canned Food",
                Unit = "can",
                Category = "Food"
            }
        };

        await context.Supplies.AddRangeAsync(supplies);
        await context.SaveChangesAsync();
    }
}