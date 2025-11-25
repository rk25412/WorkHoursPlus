using WorkHourPlus.Contracts;
using WorkHourPlus.Entities.Models;

namespace WorkHourPlus.Repositories;

public sealed class EmployeeRepository(RepositoryContext dbContext) 
    : RepositoryBase<Employee>(dbContext), IEmployeeRepository
{
    
}