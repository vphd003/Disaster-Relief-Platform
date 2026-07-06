using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DisasterReliefAPI.Models;

public class Volunteer
{
    [Key]
    public int VolunteerId { get; set; }

    public int UserId { get; set; }

    [MaxLength(255)]
    public string? Experience { get; set; }

    public byte AvailabilityStatus { get; set; }

    public byte ApprovalStatus { get; set; }

    public int? ApprovedBy { get; set; }

    public DateTime? ApprovedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual User User { get; set; } = null!;

    public virtual ICollection<VolunteerSkill> VolunteerSkills { get; set; } = new List<VolunteerSkill>();

    public virtual ICollection<Assignment> Assignments { get; set; } = new List<Assignment>();
}