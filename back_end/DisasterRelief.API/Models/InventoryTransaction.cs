using System.ComponentModel.DataAnnotations;

namespace DisasterReliefAPI.Models;

public class InventoryTransaction
{
    [Key]
    public int TransactionId { get; set; }

    public int InventoryId { get; set; }

    /// <summary>
    /// 0 = Import
    /// 1 = Export
    /// 2 = Adjustment
    /// </summary>
    public byte Type { get; set; }

    public int Quantity { get; set; }

    public int ReferenceId { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Inventory Inventory { get; set; } = null!;
}