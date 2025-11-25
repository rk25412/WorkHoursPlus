using WorkHourPlus.Contracts;
using WorkHourPlus.Services.Contracts;
using WorkHourPlus.Shared.Converters;
using WorkHourPlus.Shared.DTOs;

namespace WorkHourPlus.Services;

public class EmployeeService(IRepositoryManager repositoryManager) : IEmployeeService
{
    public async Task<List<EmployeeDto>> GetAllEmployees(int managerId, bool includeGrade = false,
        bool includeRole = false, bool includeManager = false)
    {
        var employees =
            await repositoryManager.EmployeeRepository.GetAllEmployees(managerId, includeGrade, includeRole,
                includeManager);
        return [.. employees.ToEmployeeDto()];
    }

    public async Task<EmployeeDto?> GetEmployeeById(int id)
    {
        var employee =  await repositoryManager.EmployeeRepository.GetEmployeeById(id);
        return employee.ToEmployeeDto();
    }
}