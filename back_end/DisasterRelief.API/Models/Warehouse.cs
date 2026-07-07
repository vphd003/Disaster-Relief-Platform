using System.ComponentModel.DataAnnotations;

namespace DisasterReliefAPI.Models;

public class Warehouse
{

    public int WarehouseId { get; set; }


    public string WarehouseName { get; set; } = string.Empty;


    public string? Location { get; set; }

    public int Capacity { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();
}