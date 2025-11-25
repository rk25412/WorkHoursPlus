using WorkHourPlus.Contracts;
using WorkHourPlus.Services.Contracts;
using WorkHourPlus.Shared.Converters;
using WorkHourPlus.Shared.DTOs;

namespace WorkHourPlus.Services;

public class UserService(IRepositoryManager repositoryManager) : IUserService
{
    public async Task<UserDto?> GetUserByUsername(string username)
    {
        var user = await repositoryManager.UserRepository.GetUserByUsername(username);
        return user.ToUserDto();
    }
}