using Microsoft.EntityFrameworkCore;
using WorkHourPlus.Contracts;
using WorkHourPlus.Entities.Models;

namespace WorkHourPlus.Repositories;

public sealed class GradeRepository(RepositoryContext dbContext)
    : RepositoryBase<Grade>(dbContext), IGradeRepository 
{
    public async Task<List<Grade>> GetAllGrades()
    {
        return await FindAll().ToListAsync();
    }
}