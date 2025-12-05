namespace WorkHourPlus.Shared.DTOs;

public record GradeDto(int Id, string Name);

public class AddEditGradeDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
}