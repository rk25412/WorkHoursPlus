using Microsoft.EntityFrameworkCore;
using WorkHourPlus.Entities.Models;
using WorkHourPlus.Repositories.SeedConfigurations;

namespace WorkHourPlus.Repositories;

public sealed class RepositoryContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Grade> Grades { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Shift> Shifts { get; set; }
    public DbSet<GradeRoleOvertimeRate> GradeRoleOvertimeRates { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new UserConfiguration());
    }
}