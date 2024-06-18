using System.Domain.Languages.Repositories;
using System.Infrastructure.Languages.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace System.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddScoped<ILanguageRootRepository, LanguageRootRepository>();
        services.AddScoped<ILanguageTypeRepository, LanguageTypeRepository>();
        
        return services;
    }
}