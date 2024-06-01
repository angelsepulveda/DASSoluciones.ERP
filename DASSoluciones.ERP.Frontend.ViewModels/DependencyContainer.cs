namespace DASSoluciones.ERP.Frontend.ViewModels;

public static class DependencyContainer
{
    public static IServiceCollection AddViewModels(this IServiceCollection services)
    {
        services.AddModulesViewModels();
        
        return services;
    }
}