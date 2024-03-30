using Microsoft.EntityFrameworkCore;
using OblakotekaTask.Domain.Entities;

namespace OblakotekaTask.Application.Interfaces
{
    public interface ITestDbContext
    {
        public DbSet<EventLog> EventLogs { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductVersion> ProductVersions { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
