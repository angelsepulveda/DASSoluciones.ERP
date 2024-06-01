namespace DASSoluciones.ERP.Frontend.WebApiProxies.Modules.WareHouse;

public static class DependencyContainer
{
    public static IServiceCollection AddWareHouseModels(this IServiceCollection services)
    {
        services.AddCategoriesModels();
        
        return services;
    }
}