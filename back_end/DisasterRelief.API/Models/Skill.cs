using System.ComponentModel.DataAnnotations;

namespace DisasterReliefAPI.Models;

public class Skill
{

    public int SkillId { get; set; }


    public string SkillName { get; set; } = string.Empty;


    public string? Description { get; set; }

    public virtual ICollection<VolunteerSkill> VolunteerSkills { get; set; } = new List<VolunteerSkill>();
}