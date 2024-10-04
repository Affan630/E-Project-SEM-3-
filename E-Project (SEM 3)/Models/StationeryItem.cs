﻿using System.ComponentModel.DataAnnotations;

public class StationeryItem
{
    [Key]
    public int ItemId { get; set; }

    [Required]
    [MaxLength(100)]
    public string ItemName { get; set; }

    public string Description { get; set; }

    public int AvailableStock { get; set; }

    [Required]
    public decimal UnitPrice { get; set; }

    public ICollection<Request> Requests { get; set; }
}
