using System.ComponentModel.DataAnnotations;

namespace DisasterReliefAPI.Models;

public class RequestSupply
{

    public int RequestSupplyId { get; set; }

    public int RequestId { get; set; }

    public int SupplyId { get; set; }

    public int QuantityRequested { get; set; }

    public byte Status { get; set; }

    public virtual ReliefRequest ReliefRequest { get; set; } = null!;

    public virtual Supply Supply { get; set; } = null!;
}