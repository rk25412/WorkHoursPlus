using WorkHourPlus.Entities.Models;

namespace WorkHourPlus.Contracts;

public interface IGradeRepository
{
    Task<List<Grade>> GetAllGrades();
}