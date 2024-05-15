using System.ComponentModel.DataAnnotations.Schema;

namespace Core;

[Table("department", Schema = "movies")]
public class Department
{
    public int DepartmentId { get; set; }
    public string? DepartmentName { get; set; }
}
