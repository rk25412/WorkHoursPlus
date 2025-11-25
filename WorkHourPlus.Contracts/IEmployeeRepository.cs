using WorkHourPlus.Entities.Models;

namespace WorkHourPlus.Contracts;

public interface IEmployeeRepository
{
    Task<List<Employee>> GetAllEmployees(int managerId, bool includeGrade = false, bool includeRole = false, bool includeManager = false);
    Task<Employee?> GetEmployeeById(int id);
}