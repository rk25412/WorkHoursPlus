using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components;
using WorkHourPlus.Entities.Enums;
using WorkHourPlus.Shared.DTOs;

namespace WorkHourPlus.Components.Auth.Pages;

public partial class LoginPage : ComponentBase
{
    [CascadingParameter]
    private HttpContext HttpContext { get; set; } = null!;

    [SupplyParameterFromForm(FormName = "LoginForm")]
    public LoginDto? LoginModel { get; set; }

    private string _errorMessage = "";

    protected override void OnInitialized()
    {
        LoginModel ??= new LoginDto();
    }

    private async Task HandleSubmit()
    {
        var user = await ServiceManager.UserService.GetUserByUsername(LoginModel!.Username!);
        if (user is null || !user.Password.Equals(LoginModel.Password, StringComparison.InvariantCultureIgnoreCase))
        {
            _errorMessage = "Username or password is incorrect";
            return;
        }

        var employee = user.Role is nameof(Roles.Superadmin)
            ? null
            : await ServiceManager.EmployeeService.GetEmployeeById(user.EmployeeId ?? 0);

        List<Claim> claims = [
            new(ClaimTypes.Name, employee?.Name ?? user.Username),
            new(ClaimTypes.Role, user.Role),
            new("EmployeeId", user.EmployeeId?.ToString()!),
        ];
        
        var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
        var principal = new ClaimsPrincipal(identity);
        
        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
        HttpContext.Response.Redirect("/");
    }
}