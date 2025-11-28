using WorkHourPlus.Entities.Models;

namespace WorkHourPlus.Contracts;

public interface IEmployeeRepository
{
    Task<List<Employee>> GetAll();
    Task<List<Employee>> GetAll(int managerId, bool includeGrade = false, bool includeRole = false, bool includeManager = false);
    Task<Employee?> GetAllById(int id);
}