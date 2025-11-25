namespace WorkHourPlus.Shared.DTOs;

public record EmployeeDto(int Id,
        string Name,
        string Email,
        int GradeId,
        int RoleId,
        int ManagerId,
        GradeDto? Grade = null,
        RoleDto? Role = null,
        EmployeeDto? Manager = null);