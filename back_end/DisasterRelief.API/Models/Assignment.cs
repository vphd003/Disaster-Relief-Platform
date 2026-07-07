using System.ComponentModel.DataAnnotations;

namespace DisasterReliefAPI.Models;

public class Assignment
{
   
    public int AssignmentId { get; set; }

    public int VolunteerId { get; set; }

    public int RequestId { get; set; }

    

    public DateTime AssignedAt { get; set; }

    public byte Status { get; set; }

    public virtual Volunteer Volunteer { get; set; } = null!;

    public virtual ReliefRequest ReliefRequest { get; set; } = null!;

    
}