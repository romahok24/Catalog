using Microsoft.Extensions.DependencyInjection;
using ProductCatalog.Services.Interfaces;
using ProductCatalog.Services.Services;

namespace ProductCatalog.Services
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthentificationService, AuthentificationService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IAdminService, AdminService>();

            return services;
        }
    }
}
