namespace WorkHourPlus.Contracts;

public interface IRepositoryManager
{
    IEmployeeRepository EmployeeRepository { get; }
    IGradeRepository GradeRepository { get; }
    IGradeRoleOvertimeRateRepository GradeRoleOvertimeRateRepository { get; }
    IRoleRepository RoleRepository { get; }
    IShiftRepository ShiftRepository { get; }
    IUserRepository UserRepository { get; }
    Task SaveAsync();
    void Detach();
}