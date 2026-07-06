using System.ComponentModel.DataAnnotations;

namespace DisasterReliefAPI.Models;

public class Skill
{
    [Key]
    public int SkillId { get; set; }

    [Required]
    [MaxLength(100)]
    public string SkillName { get; set; } = string.Empty;

    [MaxLength(255)]
    public string? Description { get; set; }

    public virtual ICollection<VolunteerSkill> VolunteerSkills { get; set; } = new List<VolunteerSkill>();
}