using System.ComponentModel.DataAnnotations;

namespace DisasterReliefAPI.Models;

public class Requester
{
    [Key]
    public int RequesterId { get; set; }

    public int UserId { get; set; }

    public virtual User User { get; set; } = null!;

    public virtual ICollection<ReliefRequest> ReliefRequests { get; set; } = new List<ReliefRequest>();
}