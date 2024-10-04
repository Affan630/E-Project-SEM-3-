using System.ComponentModel.DataAnnotations;

public class Role
{
    [Key]
    public int RoleId { get; set; }

    [Required]
    [MaxLength(50)]
    public string RoleName { get; set; }

    [Required]
    public decimal MaxBudget { get; set; }

    public ICollection<User> Users { get; set; }

    public ICollection<Hierarchy> Hierarchies { get; set; }
    public ICollection<Hierarchy> SuperiorRoles { get; set; }
}
