namespace WorkHourPlus.Entities.Models;

public sealed class Employee
{
    [Key] public int Id { get; set; }
    [Required] public string Name { get; set; } = string.Empty;
    [Required] public string? Email { get; set; }
    [Required] public int GradeId { get; set; }
    [Required] public int RoleId { get; set; }
    
    [ForeignKey(nameof(GradeId))] public Grade? Grade { get; set; }
    [ForeignKey(nameof(RoleId))] public Role? Role { get; set; }
    public Shift? Shift { get; set; }
}