using WorkHourPlus.Entities.Models;

namespace WorkHourPlus.Contracts;

public interface IGradeRepository
{
    Task<List<Grade>> GetAll();
    void Add(Grade grade);
    void Update(Grade grade);
    void Delete(Grade grade);
}