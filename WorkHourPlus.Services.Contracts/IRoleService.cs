using WorkHourPlus.Shared.DTOs;

namespace WorkHourPlus.Services.Contracts;

public interface IRoleService
{
    Task<List<RoleDto>> GetAll();
}