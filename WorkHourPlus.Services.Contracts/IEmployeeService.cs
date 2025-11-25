using WorkHourPlus.Shared.DTOs;

namespace WorkHourPlus.Services.Contracts;

public interface IEmployeeService
{
    Task<EmployeeDto?> GetEmployeeById(int id);
}