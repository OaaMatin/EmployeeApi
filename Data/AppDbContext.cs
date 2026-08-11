using Microsoft.EntityFrameworkCore;

namespace EmployeeApi;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {}

    public DbSet<Employee> Employees { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>().HasDiscriminator<string>("EmployeeType").HasValue<Employee>("Employee").HasValue<Manager>("Manager").HasValue<Developer>("Developer");
    }
}