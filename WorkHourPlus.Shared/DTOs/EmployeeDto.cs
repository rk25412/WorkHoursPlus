namespace WorkHourPlus.Shared.DTOs;

public record EmployeeDto(
    int Id,
    string Name,
    string Email,
    int GradeId,
    int RoleId,
    int ManagerId,
    GradeDto? Grade = null,
    RoleDto? Role = null,
    EmployeeDto? Manager = null);

public class AddEditEmployeeDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } =  string.Empty;
    public int GradeId { get; set; }
    public int RoleId { get; set; }
    public int ManagerId  { get; set; }
}