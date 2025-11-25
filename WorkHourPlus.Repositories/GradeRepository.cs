using WorkHourPlus.Contracts;
using WorkHourPlus.Entities.Models;

namespace WorkHourPlus.Repositories;

public sealed class GradeRepository(RepositoryContext dbContext)
    : RepositoryBase<Grade>(dbContext), IGradeRepository 
{
    
}