using WorkHourPlus.Contracts;

namespace WorkHourPlus.Repositories;

public sealed class RepositoryManager(RepositoryContext dbContext) : IRepositoryManager
{
    private readonly Lazy<IEmployeeRepository> _employeeRepository = new(() => new EmployeeRepository(dbContext));
    private readonly Lazy<IGradeRepository> _gradeRepository = new(() => new GradeRepository(dbContext));
    private readonly Lazy<IGradeRoleOvertimeRateRepository> _gradeRoleOvertimeRateRepository
        = new(() => new GradeRoleOvertimeRateRepository(dbContext));
    private readonly Lazy<IRoleRepository> _roleRepository = new(() => new RoleRepository(dbContext));
    private readonly Lazy<IShiftRepository>  _shiftRepository = new(() => new ShiftRepository(dbContext));
    
    public IEmployeeRepository EmployeeRepository => _employeeRepository.Value;
    public IGradeRepository GradeRepository => _gradeRepository.Value;
    public IGradeRoleOvertimeRateRepository GradeRoleOvertimeRateRepository => _gradeRoleOvertimeRateRepository.Value;
    public IRoleRepository RoleRepository => _roleRepository.Value;
    public IShiftRepository ShiftRepository => _shiftRepository.Value;
    public void Save() => dbContext.SaveChanges();
}