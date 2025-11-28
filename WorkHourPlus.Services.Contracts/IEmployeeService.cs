using WorkHourPlus.Shared.DTOs;

namespace WorkHourPlus.Services.Contracts;

public interface IEmployeeService
{
    Task<List<EmployeeDto>> GetAll();
    Task<List<EmployeeDto>> GetAll(int managerId, bool includeGrade = false, bool includeRole = false,
        bool includeManager = false);
    Task<EmployeeDto?> GetAllById(int id);
}