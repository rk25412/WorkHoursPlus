namespace WorkHourPlus.Services.Contracts;

public interface IServiceManager
{
    IEmployeeService EmployeeService { get; }
    IGradeService GradeService { get; }
    IGradeRoleOvertimeRateService GradeRoleOvertimeRateService { get; }
    IRoleService RoleService { get; }
    IShiftService ShiftService { get; }
}