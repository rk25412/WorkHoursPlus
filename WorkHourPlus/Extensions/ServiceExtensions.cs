using Microsoft.EntityFrameworkCore;
using WorkHourPlus.Contracts;
using WorkHourPlus.Repositories;
using WorkHourPlus.Services;
using WorkHourPlus.Services.Contracts;

namespace WorkHourPlus.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureRepositoryContext(this IServiceCollection services, IConfiguration configuration)
        => services.AddDbContext<RepositoryContext>(options => 
            options.UseSqlite(configuration.GetConnectionString("DefaultConnection"), opt => 
                opt.MigrationsAssembly(typeof(Program).Assembly.GetName().Name)));
    
    public static void ConfigureRepositoryManager(this IServiceCollection services)
        => services.AddScoped<IRepositoryManager, RepositoryManager>();
    
    public static void ConfigureServiceManager(this IServiceCollection services)
        => services.AddScoped<IServiceManager, ServiceManager>();

}