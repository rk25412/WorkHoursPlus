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
        var grades = await repositoryManager.GradeRepository.GetAll();
        return grades.ToGradeDto();
    }

    public async Task Add(AddEditGradeDto dto)
    {
        var grade = dto.ToGrade()!;
        repositoryManager.GradeRepository.Add(grade);
        await repositoryManager.SaveAsync();
        dto.Id = grade.Id;
    }

    public async Task Edit(AddEditGradeDto dto)
    {
        var grade = dto.ToGrade();
        repositoryManager.GradeRepository.Update(grade!);
        await repositoryManager.SaveAsync();
    }

    public async Task Delete(GradeDto dto)
    {
        repositoryManager.GradeRepository.Delete(new Grade { Id = dto.Id });
        await repositoryManager.SaveAsync();
    }
}
