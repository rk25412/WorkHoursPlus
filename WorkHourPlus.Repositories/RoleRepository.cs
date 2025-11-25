using WorkHourPlus.Contracts;
using WorkHourPlus.Entities.Models;

namespace WorkHourPlus.Repositories;

public sealed class RoleRepository(RepositoryContext dbContext)
    : RepositoryBase<Role>(dbContext), IRoleRepository
{
    
}