namespace WorkHourPlus.Entities.Models;

public class User
{
    [Key] public int Id { get; set; }
    [Required] public string? Username { get; set; }
    [Required] public string? Password { get; set; }
    [Required] public int? EmployeeId { get; set; }
    [Required] public string? Role { get; set; }
}