using System.ComponentModel.DataAnnotations;

public class User
{
    public int UserId { get; set; }

    [Required]
    [MaxLength(50)]
    public string Name { get; set; }

    [Required]
    [MaxLength(100)]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }

    // Foreign key to Role
    public int RoleId { get; set; }
    public Role Role { get; set; }
}
