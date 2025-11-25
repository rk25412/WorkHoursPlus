namespace WorkHourPlus.Entities.Models;

public sealed class Employee
{
    [Key] public int Id { get; set; }
    [Required] public string Name { get; set; } = string.Empty;
    [Required] public string Email { get; set; } = string.Empty;
    [Required] public int GradeId { get; set; }
    [Required] public int RoleId { get; set; }
    
    public int? ManagerId { get; set; }
    
    [ForeignKey(nameof(ManagerId))] public Employee? Manager { get; set; }
    [ForeignKey(nameof(GradeId))] public Grade? Grade { get; set; }
    [ForeignKey(nameof(RoleId))] public Role? Role { get; set; }

    public List<Employee> ReportingEmployees { get; set; } = [];
}