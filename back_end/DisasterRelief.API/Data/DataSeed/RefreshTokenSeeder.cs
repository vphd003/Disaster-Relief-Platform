using DisasterRelief.API.Data;
using DisasterReliefAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DisasterRelief.API.DataSeed;

public static class RefreshTokenSeeder
{
    public static async Task SeedAsync(AppDbContext context)
    {
        if (await context.RefreshTokens.AnyAsync())
            return;

        var refreshTokens = new List<RefreshToken>();

        int tokenId = 1;

        foreach (var user in await context.Users.ToListAsync())
        {
            refreshTokens.Add(new RefreshToken
            {
                RefreshTokenId = tokenId++,
                UserId = user.UserId,
                Token = Guid.NewGuid().ToString("N"),
                CreatedAt = DateTime.UtcNow.AddDays(-1),
                ExpiresAt = DateTime.UtcNow.AddDays(30),
                RevokedAt = null,
                IsRevoked = false
            });
        }

        await context.RefreshTokens.AddRangeAsync(refreshTokens);
        await context.SaveChangesAsync();
    }
}