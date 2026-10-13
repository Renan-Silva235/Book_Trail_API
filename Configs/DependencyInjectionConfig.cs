using BookTrail_Api.DbContext;
using BookTrail_Api.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection; // Certifique-se de ter essa namespace
using Microsoft.Extensions.Configuration;

namespace BookTrail_Api.Configs
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers();
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite(configuration.GetConnectionString("DefaultConnection")));
            services.AddOpenApi();
            services.AddScoped<UserService>();
            return services;
        }
    }
}
