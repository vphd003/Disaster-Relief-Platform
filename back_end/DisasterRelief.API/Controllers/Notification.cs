using System.ComponentModel.DataAnnotations;

namespace DisasterReliefAPI.Models;

public class Notification
{
    [Key]
    public int NotificationId { get; set; }

    public int UserId { get; set; }

    [Required]
    [MaxLength(200)]
    public string Title { get; set; } = string.Empty;

    public string? Content { get; set; }

    [MaxLength(50)]
    public string? Type { get; set; }

    public bool IsRead { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual User User { get; set; } = null!;
}