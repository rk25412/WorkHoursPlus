using Microsoft.EntityFrameworkCore;
using WorkHourPlus.Contracts;
using WorkHourPlus.Entities.Models;

namespace WorkHourPlus.Repositories;

public sealed class EmployeeRepository(RepositoryContext dbContext) 
    : RepositoryBase<Employee>(dbContext), IEmployeeRepository
{
    public async Task<Employee?> GetEmployeeById(int id)
    {
        var employee = await FindByCondition(x => x.Id == id)
                .FirstOrDefaultAsync();
        
        return employee;
    }
}