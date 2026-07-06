using System.ComponentModel.DataAnnotations;

namespace DisasterReliefAPI.Models;

public class Warehouse
{
    [Key]
    public int WarehouseId { get; set; }

    [Required]
    [MaxLength(100)]
    public string WarehouseName { get; set; } = string.Empty;

    [MaxLength(255)]
    public string? Location { get; set; }

    public int Capacity { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();
}