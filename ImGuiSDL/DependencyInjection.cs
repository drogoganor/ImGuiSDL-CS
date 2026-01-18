using Microsoft.Extensions.DependencyInjection;

namespace ImGuiSDL;

public static class DependencyInjection
{
    public static IServiceCollection AddEngine(this IServiceCollection services)
    {
        services.AddSingleton<Application>();

        return services;
    }
}