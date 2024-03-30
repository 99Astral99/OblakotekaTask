using Microsoft.EntityFrameworkCore;
using OblakotekaTask.Application.Interfaces;
using OblakotekaTask.Domain.Entities;

namespace OblakotekaTask.Infrastructure.Data;

public partial class TestDbContext : DbContext, ITestDbContext
{
    public TestDbContext()
    {
    }

    public TestDbContext(DbContextOptions<TestDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<EventLog> EventLogs { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductVersion> ProductVersions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(TestDbContext).Assembly);
    }
}
