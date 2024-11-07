using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using EducationManagementSolution.Infrastructure.Data;

namespace EducationManagementSolution.Infrastructure;

public static class InfrastructureDependencyInjection
{
    public static IServiceCollection AddInfrastructureDependency(this IServiceCollection services,IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("Server=DESKTOP-4AQFFCU;Database=EducationSystem_Db;User=sa;Password=123456;MultipleActiveResultSets=true;TrustServerCertificate=true"));
        });

        return services;
    }
}
