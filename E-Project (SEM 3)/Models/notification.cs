using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Notification
{
    [Key]
    public int NotificationId { get; set; }

    public int UserId { get; set; }
    [ForeignKey("UserId")]
    public User User { get; set; }

    [Required]
    public string Message { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public bool IsRead { get; set; } = false;
}
