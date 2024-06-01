namespace DASSoluciones.ERP.Frontend.WebApiProxies;

public static class DependencyContainer
{
    public static IServiceCollection AddModels(this IServiceCollection services)
    {
        services.AddModulesModels();
        
        return services;
    }
}