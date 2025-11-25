using WorkHourPlus.Shared.DTOs;

namespace WorkHourPlus.Services.Contracts;

public interface IUserService
{
    Task<UserDto?> GetUserByUsername(string username);
}