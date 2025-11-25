using WorkHourPlus.Entities.Models;

namespace WorkHourPlus.Contracts;

public interface IUserRepository
{
    Task<User?> GetUserByUsername(string username);
}