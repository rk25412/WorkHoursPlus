using WorkHourPlus.Contracts;
using WorkHourPlus.Entities.Models;
using WorkHourPlus.Services.Contracts;
using WorkHourPlus.Shared.Converters;
using WorkHourPlus.Shared.DTOs;

namespace WorkHourPlus.Services;

public class GradeService(IRepositoryManager repositoryManager) : IGradeService
{
    public async Task<List<GradeDto>> GetAll()
    {
        var grades = await repositoryManager.GradeRepository.GetAllGrades();
        return grades.ToGradeDto();
    }
}
