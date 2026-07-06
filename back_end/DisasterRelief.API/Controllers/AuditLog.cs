using System.ComponentModel.DataAnnotations;

namespace DisasterReliefAPI.Models;

public class AuditLog
{
    [Key]
    public int AuditId { get; set; }

    public int UserId { get; set; }

    [Required]
    [MaxLength(100)]
    public string Action { get; set; } = string.Empty;

    [Required]
    [MaxLength(100)]
    public string Entity { get; set; } = string.Empty;

    public int EntityId { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual User User { get; set; } = null!;
}