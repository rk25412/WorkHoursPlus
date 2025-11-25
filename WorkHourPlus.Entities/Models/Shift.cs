namespace WorkHourPlus.Entities.Models;

public sealed class Shift
{
    [Key] public int Id { get; set; }
    [Required] public int EmployeeId { get; set; }
    [Required] public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime => StartTime.AddHours(8);
    
    [ForeignKey(nameof(EmployeeId))] public Employee? Employee { get; set; }
}