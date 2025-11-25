using WorkHourPlus.Contracts;
using WorkHourPlus.Entities.Models;

namespace WorkHourPlus.Repositories;

public sealed class ShiftRepository(RepositoryContext dbContext) 
    : RepositoryBase<Shift>(dbContext), IShiftRepository
{
    
}