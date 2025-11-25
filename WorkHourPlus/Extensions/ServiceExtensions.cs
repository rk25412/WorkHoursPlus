using Microsoft.EntityFrameworkCore;
using WorkHourPlus.Repositories;
using WorkHourPlus.Services;

namespace WorkHourPlus.Extensions;

public static class ServiceExtensions
{
    extension(IServiceCollection services)
    {
        public void ConfigureRepositoryContext(IConfiguration configuration)
            => services.AddDbContext<RepositoryContext>(options =>
                options.UseSqlite(configuration.GetConnectionString("DefaultConnection"), opt =>
                    opt.MigrationsAssembly(typeof(Program).Assembly.GetName().Name)));

        public void ConfigureRepositoryManager()
            => services.AddScoped<IRepositoryManager, RepositoryManager>();

        public void ConfigureServiceManager()
            => services.AddScoped<IServiceManager, ServiceManager>();
    }
}