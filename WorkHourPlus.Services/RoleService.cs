using System.Net.Http.Headers;
using WorkHourPlus.Contracts;
using WorkHourPlus.Services.Contracts;
using WorkHourPlus.Shared.Converters;
using WorkHourPlus.Shared.DTOs;

namespace WorkHourPlus.Services;

public class RoleService(IRepositoryManager repositoryManager) : IRoleService
{
    public async Task<List<RoleDto>> GetAll()
    {
        var roles = await repositoryManager.RoleRepository.GetAll(); 
        return [.. roles.ToRoleDto()];
    }
}