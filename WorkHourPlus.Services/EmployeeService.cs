using WorkHourPlus.Contracts;
using WorkHourPlus.Services.Contracts;
using WorkHourPlus.Shared.Converters;
using WorkHourPlus.Shared.DTOs;

namespace WorkHourPlus.Services;

public class EmployeeService(IRepositoryManager repositoryManager) : IEmployeeService
{
    public async Task<List<EmployeeDto>> GetAll()
    {
        var employees = await repositoryManager.EmployeeRepository.GetAll();
        return [..employees.ToEmployeeDto()];
    }
    
    public async Task<List<EmployeeDto>> GetAll(int managerId, bool includeGrade = false,
        bool includeRole = false, bool includeManager = false)
    {
        var employees =
            await repositoryManager.EmployeeRepository.GetAll(managerId, includeGrade, includeRole,
                includeManager);
        return [.. employees.ToEmployeeDto()];
    }

    public async Task<EmployeeDto?> GetAllById(int id)
    {
        var employee =  await repositoryManager.EmployeeRepository.GetAllById(id);
        return employee.ToEmployeeDto();
    }
}