using WorkHourPlus.Shared.DTOs;

namespace WorkHourPlus.Services.Contracts;

public interface IGradeService
{
    Task<List<GradeDto>> GetAll();
}