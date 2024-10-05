using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Role
{
    public int RoleId { get; set; }

    [Required]
    [MaxLength(50)]
    public string RoleName { get; set; }

    // Specify precision and scale for MaxBudget
    [Column(TypeName = "decimal(18, 2)")]
    public decimal MaxBudget { get; set; }

    public ICollection<User> Users { get; set; }
}
