using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class StationeryItem
{
    public int StationeryItemId { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    // Specify precision and scale for UnitCost
    [Column(TypeName = "decimal(18, 2)")]
    public decimal UnitCost { get; set; }

    public int Quantity { get; set; }
}
