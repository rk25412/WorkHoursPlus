using WorkHourPlus.Shared.DTOs;

namespace WorkHourPlus.Services.Contracts;

public interface IEmployeeService
{
    Task<List<EmployeeDto>> GetAllEmployees(int managerId, bool includeGrade = false, bool includeRole = false,
        bool includeManager = false);
    Task<EmployeeDto?> GetEmployeeById(int id);
}