using WorkHourPlus.Contracts;
using WorkHourPlus.Services.Contracts;

namespace WorkHourPlus.Services;

public class ServiceManager(IRepositoryManager repositoryManager) : IServiceManager
{
    private readonly Lazy<IEmployeeService> _employeeService = new(() => new EmployeeService(repositoryManager));
    private readonly Lazy<IGradeService> _gradeService = new(() => new GradeService(repositoryManager));
    private readonly Lazy<IGradeRoleOvertimeRateService> _gradeRoleOvertimeService 
        = new(() => new GradeRoleOvertimeRateService(repositoryManager));
    private readonly Lazy<IRoleService> _roleService = new(() => new RoleService(repositoryManager));
    private readonly Lazy<IShiftService> _shiftService = new(() => new ShiftService(repositoryManager));
    private readonly Lazy<IUserService> _userService = new(() => new UserService(repositoryManager));
    
    public IEmployeeService EmployeeService => _employeeService.Value;
    public IGradeService GradeService => _gradeService.Value;
    public IGradeRoleOvertimeRateService GradeRoleOvertimeRateService => _gradeRoleOvertimeService.Value;
    public IRoleService RoleService => _roleService.Value;
    public IShiftService ShiftService => _shiftService.Value;
    public IUserService UserService => _userService.Value;
}