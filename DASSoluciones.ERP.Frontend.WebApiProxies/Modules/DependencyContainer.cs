namespace DASSoluciones.ERP.Frontend.WebApiProxies.Modules;

public static class DependencyContainer
{
    public static IServiceCollection AddModulesModels(this IServiceCollection services)
    {
        services.AddWareHouseModels();
        
        return services;
    }
}