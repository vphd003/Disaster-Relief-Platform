using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DisasterReliefAPI.Models;

public class ReliefRequest
{
   
    public int RequestId { get; set; }

    public int RequesterId { get; set; }

   
    public string Title { get; set; } = string.Empty;

    public string? Description { get; set; }

 
    public string? Priority { get; set; }

    public byte Status { get; set; }


    public string? Location { get; set; }

 
    public decimal Latitude { get; set; }


    public decimal Longitude { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Requester Requester { get; set; } = null!;

    public virtual ICollection<Assignment> Assignments { get; set; } = new List<Assignment>();

    public virtual ICollection<RequestSupply> RequestSupplies { get; set; } = new List<RequestSupply>();
}