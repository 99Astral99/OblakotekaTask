using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OblakotekaTask.Application.Interfaces;
using OblakotekaTask.Domain.Entities;
using OblakotekaTask.Infrastructure.Data;
using OblakotekaTask.Infrastructure.Interfaces;
using OblakotekaTask.Infrastructure.Repositories;

namespace OblakotekaTask.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services,
            IConfiguration configuration)
        {
            var connectionString = configuration["ConnectionStrings:mssql-connection"];

            services.AddDbContext<TestDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            services.AddScoped<IBaseRepository<Product>, ProductRepository>();

            services.AddScoped<ITestDbContext>(provider =>
                provider.GetService<TestDbContext>()!);

            return services;
        }
    }
}
