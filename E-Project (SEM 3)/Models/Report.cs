using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

public class Report
{
    [Key]
    public int ReportId { get; set; }

    public int GeneratedBy { get; set; }
    [ForeignKey("GeneratedBy")]
    public User User { get; set; }

    public decimal TotalCost { get; set; }

    [Required]
    public string ReportDetails { get; set; } // Store as JSON string

    public DateTime GeneratedAt { get; set; } = DateTime.Now;
}
