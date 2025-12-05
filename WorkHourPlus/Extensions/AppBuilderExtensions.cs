using Microsoft.EntityFrameworkCore;
using WorkHourPlus.Repositories;

namespace WorkHourPlus.Extensions;

public static class AppBuilderExtensions
{
    extension (IApplicationBuilder app)
    {
        public void MigrateDatabase()
        {
            var dbContext = app.ApplicationServices.CreateScope().ServiceProvider
                .GetRequiredService<RepositoryContext>();

            if (dbContext.Database.GetPendingMigrations().Any())
            {
                dbContext.Database.Migrate();
            }
        }
    }
}