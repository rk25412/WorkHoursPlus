using Microsoft.EntityFrameworkCore;
using WorkHourPlus.Contracts;
using WorkHourPlus.Entities.Models;

namespace WorkHourPlus.Repositories;

public class UserRepository(RepositoryContext dbContext) 
    : RepositoryBase<User>(dbContext), IUserRepository
{
    public async Task<User?> GetUserByUsername(string username)
    {
        var user = await FindByCondition(x => x.Username!.ToLower() == username.ToLower())
            .FirstOrDefaultAsync();
        return user;
    }
}