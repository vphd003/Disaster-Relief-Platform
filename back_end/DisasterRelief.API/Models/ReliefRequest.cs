using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DisasterReliefAPI.Models;

public class ReliefRequest
{
    [Key]
    public int RequestId { get; set; }

    public int RequesterId { get; set; }

    [Required]
    [MaxLength(200)]
    public string Title { get; set; } = string.Empty;

    public string? Description { get; set; }

    [MaxLength(20)]
    public string? Priority { get; set; }

    public byte Status { get; set; }

    [MaxLength(255)]
    public string? Location { get; set; }

    [Column(TypeName = "decimal(10,7)")]
    public decimal Latitude { get; set; }

    [Column(TypeName = "decimal(10,7)")]
    public decimal Longitude { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Requester Requester { get; set; } = null!;

    public virtual ICollection<Assignment> Assignments { get; set; } = new List<Assignment>();

    public virtual ICollection<RequestSupply> RequestSupplies { get; set; } = new List<RequestSupply>();
}