using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Request
{
    [Key]
    public int RequestId { get; set; }

    public int UserId { get; set; }
    [ForeignKey("UserId")]
    public User User { get; set; }

    public int ItemId { get; set; }
    [ForeignKey("ItemId")]
    public StationeryItem Item { get; set; }

    [Required]
    public int Quantity { get; set; }

    [Required]
    public decimal TotalCost { get; set; }

    [Required]
    public RequestStatus Status { get; set; } = RequestStatus.Pending;

    public int? ManagerId { get; set; }
    [ForeignKey("ManagerId")]
    public User Approver { get; set; }

    public DateTime RequestedAt { get; set; } = DateTime.Now;
    public DateTime? ApprovedAt { get; set; }
    public DateTime? CancelledAt { get; set; }
    public DateTime? WithdrawnAt { get; set; }
}

public enum RequestStatus
{
    Pending,
    Approved,
    Rejected,
    Withdrawn,
    Cancelled
}
