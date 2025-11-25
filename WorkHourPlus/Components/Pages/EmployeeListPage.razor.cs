using Microsoft.AspNetCore.Components;
using WorkHourPlus.Shared.DTOs;

namespace WorkHourPlus.Components.Pages;

public partial class EmployeeListPage : ComponentBase
{
    [CascadingParameter(Name = "CurrentEmployeeId")]
    public int EmployeeId { get; set; }

    private List<EmployeeDto> _employees = [];

    protected override async Task OnInitializedAsync()
    {
        _employees = await ServiceManager.EmployeeService.GetAllEmployees(EmployeeId);
    }
}