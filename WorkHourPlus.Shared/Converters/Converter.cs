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

    extension(IEnumerable<Employee> employees)
    {
        public IEnumerable<EmployeeDto> ToEmployeeDto()
        {
            return employees.Select(x => x.ToEmployeeDto()!);
        }
    }

    extension(Grade? grade)
    {
        public GradeDto? ToGradeDto()
        {
            return grade is null
                ? null
                : new GradeDto(grade.Id, grade.Name);
        }
    }

    extension(List<Grade> grades)
    {
        public List<GradeDto> ToGradeDto()
        {
            return [.. grades.Select(x => x.ToGradeDto()!)];
        }
    }

    extension(Role? role)
    {
        public RoleDto? ToRoleDto()
        {
            return role is null
                ? null
                : new RoleDto(role.Id, role.Name);
        }
    }

    extension(IEnumerable<Role> roles)
    {
        public IEnumerable<RoleDto> ToRoleDto()
        {
            return roles.Select(x => x.ToRoleDto()!);
        }
    }

    extension(GradeDto? gradeDto)
    {
        public Grade? ToGrade()
        {
            return gradeDto is null
                ? null
                : new Grade()
                {
                    Id = gradeDto.Id,
                    Name = gradeDto.Name,
                };
        }
    }

    extension(AddEditGradeDto? addEditGradeDto)
    {
        public Grade? ToGrade()
        {
            return addEditGradeDto is null
                ? null
                : new Grade()
                {
                    Id = addEditGradeDto.Id,
                    Name = addEditGradeDto.Name,
                };
        }
    }
}