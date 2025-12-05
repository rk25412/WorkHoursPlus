using Microsoft.EntityFrameworkCore;
using WorkHourPlus.Contracts;
using WorkHourPlus.Entities.Models;

namespace WorkHourPlus.Repositories;

public sealed class GradeRepository(RepositoryContext dbContext)
    : RepositoryBase<Grade>(dbContext), IGradeRepository 
{
    public async Task<List<Grade>> GetAll()
    {
        return await FindAll().ToListAsync();
    }

    public void Add(Grade grade)
    {
        Create(grade);
    }
}