using WorkHourPlus.Shared.DTOs;

namespace WorkHourPlus.Services.Contracts;

public interface IGradeService
{
    Task<List<GradeDto>> GetAll();
    Task Add(AddEditGradeDto dto);
    Task Edit(AddEditGradeDto dto);
    Task Delete(GradeDto dto);
}