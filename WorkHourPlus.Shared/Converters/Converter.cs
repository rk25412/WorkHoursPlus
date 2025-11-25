using WorkHourPlus.Entities.Models;
using WorkHourPlus.Shared.DTOs;

namespace WorkHourPlus.Shared.Converters;

public static class Converter
{
    extension(User? user)
    {
        public UserDto? ToUserDto()
        {
            return user is null 
                ? null 
                : new UserDto(user.Id, user.Username!, user.Password!, user.Role!, user.EmployeeId);
        }
    }

    extension(Employee? employee)
    {
        public EmployeeDto? ToEmployeeDto()
        {
            return employee is null
                ? null
                : new EmployeeDto(employee.Id, employee.Name, employee.Email, employee.GradeId, employee.RoleId, employee.ManagerId ?? 0);
        }
    }
}