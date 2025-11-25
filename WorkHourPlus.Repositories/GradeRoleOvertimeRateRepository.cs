using WorkHourPlus.Contracts;
using WorkHourPlus.Entities.Models;

namespace WorkHourPlus.Repositories;

public sealed class GradeRoleOvertimeRateRepository(RepositoryContext dbContext) 
    : RepositoryBase<GradeRoleOvertimeRate>(dbContext), IGradeRoleOvertimeRateRepository
{
    
}