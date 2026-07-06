using System.ComponentModel.DataAnnotations;

namespace DisasterReliefAPI.Models;

public class RefreshToken
{
   
    public int RefreshTokenId { get; set; }

    public int UserId { get; set; }


    public string Token { get; set; } = string.Empty;

    public DateTime ExpiresAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? RevokedAt { get; set; }

    public bool IsRevoked { get; set; }

    public virtual User User { get; set; } = null!;
}