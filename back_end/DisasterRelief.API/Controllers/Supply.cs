using System.ComponentModel.DataAnnotations;

namespace DisasterReliefAPI.Models;

public class Supply
{
    [Key]
    public int SupplyId { get; set; }

    [Required]
    [MaxLength(100)]
    public string SupplyName { get; set; } = string.Empty;

    [MaxLength(30)]
    public string? Unit { get; set; }

    [MaxLength(50)]
    public string? Category { get; set; }

    public virtual ICollection<RequestSupply> RequestSupplies { get; set; } = new List<RequestSupply>();

    public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();
}