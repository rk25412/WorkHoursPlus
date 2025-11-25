namespace WorkHourPlus.Entities.Models;

public sealed class GradeRoleOvertimeRate
{
    [Key] public int Id { get; set; }
    [Required] public int GradeId { get; set; }
    [Required] public int RoleId { get; set; }
    [Required] public decimal OffHourHourlyRate { get; set; }
    [Required] public decimal OnCallSupport { get; set; }
    [Required] public decimal WeekdaySupportRate { get; set; }
    
    [ForeignKey(nameof(GradeId))] public Grade? Grade { get; set; }
    [ForeignKey(nameof(RoleId))] public Role? Role { get; set; }
}