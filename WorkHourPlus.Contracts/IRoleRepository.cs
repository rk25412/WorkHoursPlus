using WorkHourPlus.Entities.Models;

namespace WorkHourPlus.Contracts;

public interface IRoleRepository
{
    Task<List<Role>> GetAll();
}