using WorkHourPlus.Contracts;
using WorkHourPlus.Services.Contracts;
using WorkHourPlus.Shared.Converters;
using WorkHourPlus.Shared.DTOs;

namespace WorkHourPlus.Services;

public class EmployeeService(IRepositoryManager repositoryManager) : IEmployeeService
{
    public async Task<EmployeeDto?> GetEmployeeById(int id)
    {
        var employee =  await repositoryManager.EmployeeRepository.GetEmployeeById(id);
        return employee.ToEmployeeDto();
    }
}