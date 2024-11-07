using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace EducationManagementSolution.Application;

public static class ApplicationDependencyInjection
{
    public static IServiceCollection AddApplicationDependency(this IServiceCollection services)
    {
        var assembly = typeof(ApplicationDependencyInjection).Assembly;
        services.AddMediatR(config =>
        {
            config.RegisterServicesFromAssembly(assembly);
        });
        services.AddValidatorsFromAssembly(assembly);

        return services;
    }
}
