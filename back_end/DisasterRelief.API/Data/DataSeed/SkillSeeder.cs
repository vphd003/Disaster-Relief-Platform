using DisasterReliefAPI.Data;
using DisasterReliefAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DisasterRelief.API.DataSeed;

public static class SkillSeeder
{
    public static async Task SeedAsync(AppDbContext context)
    {
        if (await context.Skills.AnyAsync())
            return;

        var skills = new List<Skill>
        {
            new()
            {
               
                SkillName = "First Aid",
                Description = "Provide first aid and emergency medical support."
            },
            new()
            {
                
                SkillName = "Rescue",
                Description = "Participate in rescue operations during disasters."
            },
            new()
            {
                
                SkillName = "Logistics",
                Description = "Manage transportation and distribution of relief supplies."
            },
            new()
            {
                
                SkillName = "Driving",
                Description = "Operate relief vehicles and transport people or supplies."
            },
            new()
            {
                
                SkillName = "Cooking",
                Description = "Prepare meals for victims and volunteers."
            },
            new()
            {
                
                SkillName = "Communication",
                Description = "Coordinate communication between rescue teams."
            },
            new()
            {
              
                SkillName = "Water Rescue",
                Description = "Perform rescue operations in flooded areas."
            },
            new()
            {
               
                SkillName = "Psychological Support",
                Description = "Provide emotional support for disaster victims."
            },
            new()
            {
                
                SkillName = "Electrical Repair",
                Description = "Repair temporary electrical systems in emergency areas."
            },
            new()
            {
               
                SkillName = "Construction",
                Description = "Build temporary shelters and repair damaged facilities."
            }
        };

        await context.Skills.AddRangeAsync(skills);
        await context.SaveChangesAsync();
    }
}