using System;
using System.ComponentModel.DataAnnotations;

public class Request
{
    public int RequestId { get; set; }

    [Required]
    public DateTime RequestDate { get; set; }

    // Foreign key to User (who requested)
    public int RequestorId { get; set; }
    public User Requestor { get; set; }

    // Foreign key to StationeryItem
    public int StationeryItemId { get; set; }
    public StationeryItem StationeryItem { get; set; }

    [Required]
    public int QuantityRequested { get; set; }

    [Required]
    public string Status { get; set; }
}
