using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Hierarchy
{
    [Key]
    public int HierarchyId { get; set; }

    public int RoleId { get; set; }
    [ForeignKey("RoleId")]
    public Role Role { get; set; }

    public int SuperiorRoleId { get; set; }
    [ForeignKey("SuperiorRoleId")]
    public Role Superior { get; set; }
}
