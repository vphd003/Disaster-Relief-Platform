using System.ComponentModel.DataAnnotations;

namespace DisasterReliefAPI.Models;

public class Role
{
    [Key]
    public int RoleId { get; set; }

    [Required]
    [MaxLength(50)]
    public string RoleName { get; set; } = string.Empty;

    [MaxLength(255)]
    public string? Description { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}