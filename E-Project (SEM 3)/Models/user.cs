using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

public class User
{
    [Key]
    public int UserId { get; set; }

    [Required]
    [MaxLength(20)]
    public string EmployeeNumber { get; set; }

    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; }

    [Required]
    [MaxLength(50)]
    public string LastName { get; set; }

    [Required]
    [MaxLength(100)]
    public string Email { get; set; }

    [Required]
    public string PasswordHash { get; set; }

    public int RoleId { get; set; }
    [ForeignKey("RoleId")]
    public Role Role { get; set; }

    public int? ManagerId { get; set; }
    [ForeignKey("ManagerId")]
    public User Manager { get; set; }

    [InverseProperty("Manager")]
    public ICollection<User> Subordinates { get; set; }

    public string Location { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    public ICollection<Request> Requests { get; set; }
    public ICollection<Request> Approvals { get; set; }
}
