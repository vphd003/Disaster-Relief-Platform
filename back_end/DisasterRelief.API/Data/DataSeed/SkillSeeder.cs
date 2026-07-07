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
                SkillId = 1,
                SkillName = "First Aid",
                Description = "Provide first aid and emergency medical support."
            },
            new()
            {
                SkillId = 2,
                SkillName = "Rescue",
                Description = "Participate in rescue operations during disasters."
            },
            new()
            {
                SkillId = 3,
                SkillName = "Logistics",
                Description = "Manage transportation and distribution of relief supplies."
            },
            new()
            {
                SkillId = 4,
                SkillName = "Driving",
                Description = "Operate relief vehicles and transport people or supplies."
            },
            new()
            {
                SkillId = 5,
                SkillName = "Cooking",
                Description = "Prepare meals for victims and volunteers."
            },
            new()
            {
                SkillId = 6,
                SkillName = "Communication",
                Description = "Coordinate communication between rescue teams."
            },
            new()
            {
                SkillId = 7,
                SkillName = "Water Rescue",
                Description = "Perform rescue operations in flooded areas."
            },
            new()
            {
                SkillId = 8,
                SkillName = "Psychological Support",
                Description = "Provide emotional support for disaster victims."
            },
            new()
            {
                SkillId = 9,
                SkillName = "Electrical Repair",
                Description = "Repair temporary electrical systems in emergency areas."
            },
            new()
            {
                SkillId = 10,
                SkillName = "Construction",
                Description = "Build temporary shelters and repair damaged facilities."
            }
        };

        await context.Skills.AddRangeAsync(skills);
        await context.SaveChangesAsync();
    }
}