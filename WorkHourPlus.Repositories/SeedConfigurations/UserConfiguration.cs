using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkHourPlus.Entities.Models;

namespace WorkHourPlus.Repositories.SeedConfigurations;

public sealed class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasData([
            new User
            {
                Id = 1,
                Username = "Superadmin",
                Password = "Superadmin",
                EmployeeId = 0,
                Role = "Superadmin"
            }
        ]);
    }
}