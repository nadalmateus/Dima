using Dima.Core.Enums;

namespace Dima.Core.Models;

public class Transaction : Model
{
    public string Title { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? PaidOrReceivedAt { get; set; }
    public ETransactionType Type { get; set; } = ETransactionType.Withdrawal;
    public decimal Amount { get; set; }
    public Category Category { get; set; } = null!;
    public long CategoryId { get; set; }
    public string UserId { get; set; } = String.Empty;
}