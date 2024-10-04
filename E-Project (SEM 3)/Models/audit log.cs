using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class AuditLog
{
    [Key]
    public int LogId { get; set; }

    public int UserId { get; set; }
    [ForeignKey("UserId")]
    public User User { get; set; }

    [Required]
    [MaxLength(100)]
    public string Action { get; set; }

    public string ActionDetails { get; set; }

    public DateTime ActionTime { get; set; } = DateTime.Now;
}
