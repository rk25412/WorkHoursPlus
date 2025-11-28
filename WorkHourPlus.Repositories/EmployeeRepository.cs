using Microsoft.EntityFrameworkCore;
using WorkHourPlus.Contracts;
using WorkHourPlus.Entities.Models;

namespace WorkHourPlus.Repositories;

public sealed class EmployeeRepository(RepositoryContext dbContext) 
    : RepositoryBase<Employee>(dbContext), IEmployeeRepository
{
    public async Task<List<Employee>> GetAll()
    {
        return await FindAll().ToListAsync();
    }
    
    public async Task<List<Employee>> GetAll(int managerId, bool includeGrade = false,
        bool includeRole = false, bool includeManager = false)
    {
        var employees = managerId is 0
            ? FindAll()
            : FindByCondition(e => e.ManagerId == managerId);

        if (includeGrade)
            employees = employees.Include(g => g.Grade);
        
        if (includeRole)
            employees = employees.Include(g => g.Role);
        
        if (includeManager)
            employees = employees.Include(g => g.Manager);
        
        return await employees.ToListAsync();
    }

    public async Task<Employee?> GetAllById(int id)
    {
        var employee = await FindByCondition(x => x.Id == id)
                .FirstOrDefaultAsync();
        return employee;
    }
}