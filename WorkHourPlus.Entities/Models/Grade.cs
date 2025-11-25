namespace WorkHourPlus.Entities.Models;

public sealed class Grade
{
    [Key] public int Id { get; set; }
    [Required] public string Name { get; set; } = string.Empty;
}