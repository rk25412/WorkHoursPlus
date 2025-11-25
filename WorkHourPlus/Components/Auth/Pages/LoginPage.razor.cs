using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components;
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

        List<Claim> claims = [
            new Claim(ClaimTypes.Name, user.Id.ToString()),
            new Claim(ClaimTypes.Role, user.Role),
            new Claim("EmployeeId", user.EmployeeId?.ToString()!),
        ];
        
        var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
        var principal = new ClaimsPrincipal(identity);
        
        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
        HttpContext.Response.Redirect("/");
    }
}