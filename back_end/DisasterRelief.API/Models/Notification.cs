using System.ComponentModel.DataAnnotations;

namespace DisasterReliefAPI.Models;

public class Notification
{
  
    public int NotificationId { get; set; }

    public int UserId { get; set; }


    public string Title { get; set; } = string.Empty;

    public string? Content { get; set; }


    public string? Type { get; set; }

    public bool IsRead { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual User User { get; set; } = null!;
}