using Microsoft.Extensions.DependencyInjection;
using OblakotekaTask.Application.Implementations;
using OblakotekaTask.Application.Interfaces;

namespace OblakotekaTask.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            return services;
        }
    }
}
