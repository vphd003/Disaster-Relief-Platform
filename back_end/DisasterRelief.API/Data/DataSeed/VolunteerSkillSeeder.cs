using DisasterReliefAPI.Data;
using DisasterReliefAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DisasterRelief.API.DataSeed;

public static class VolunteerSkillSeeder
{
    public static async Task SeedAsync(AppDbContext context)
    {
        if (await context.VolunteerSkills.AnyAsync())
            return;

        var volunteerSkills = new List<VolunteerSkill>
        {
            new() { VolunteerId = 1, SkillId = 1 },
            new() { VolunteerId = 1, SkillId = 2 },

            new() { VolunteerId = 2, SkillId = 1 },
            new() { VolunteerId = 2, SkillId = 6 },

            new() { VolunteerId = 3, SkillId = 3 },
            new() { VolunteerId = 3, SkillId = 5 },

            new() { VolunteerId = 4, SkillId = 1 },
            new() { VolunteerId = 4, SkillId = 8 },

            new() { VolunteerId = 5, SkillId = 2 },
            new() { VolunteerId = 5, SkillId = 7 },

            new() { VolunteerId = 6, SkillId = 3 },
            new() { VolunteerId = 6, SkillId = 4 },

            new() { VolunteerId = 7, SkillId = 6 },
            new() { VolunteerId = 7, SkillId = 9 },

            new() { VolunteerId = 8, SkillId = 10 },
            new() { VolunteerId = 8, SkillId = 5 }
        };

        await context.VolunteerSkills.AddRangeAsync(volunteerSkills);
        await context.SaveChangesAsync();
    }
}