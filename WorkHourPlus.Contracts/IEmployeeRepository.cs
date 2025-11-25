using WorkHourPlus.Entities.Models;

namespace WorkHourPlus.Contracts;

public interface IEmployeeRepository
{
    Task<Employee?> GetEmployeeById(int id);
}