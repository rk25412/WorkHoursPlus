namespace WorkHourPlus.Shared.DTOs;

public record UserDto(int Id, string Username, string Password, string Role, int? EmployeeId);