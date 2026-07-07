using DisasterRelief.API.Data;
using DisasterReliefAPI.Data;
using DisasterReliefAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DisasterRelief.API.DataSeed;

public static class AssignmentSeeder
{
    public static async Task SeedAsync(AppDbContext context)
    {
        if (await context.Assignments.AnyAsync())
            return;


        var requests = await context.ReliefRequests
            .ToListAsync();

        var volunteers = await context.Volunteers
            .ToListAsync();


        var assignments = new List<Assignment>();


        assignments.Add(new Assignment
        {
            RequestId = requests[0].RequestId,
            VolunteerId = volunteers[0].VolunteerId,
            Status = 1,
            AssignedAt = DateTime.UtcNow
        });


        assignments.Add(new Assignment
        {
            RequestId = requests[1].RequestId,
            VolunteerId = volunteers[1].VolunteerId,
            Status = 1,
            AssignedAt = DateTime.UtcNow
        });


        await context.Assignments.AddRangeAsync(assignments);
        await context.SaveChangesAsync();
    }

}