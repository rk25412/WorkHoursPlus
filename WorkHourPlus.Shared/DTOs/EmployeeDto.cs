namespace WorkHourPlus.Shared.DTOs;

public record EmployeeDto(int Id,
        string Name,
        string Email,
        int GradeId,
        int RoleId,
        int ManagerId);