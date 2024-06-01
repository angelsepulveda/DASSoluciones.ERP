namespace DASSoluciones.ERP.Frontend.WebApiProxies.Modules.WareHouse.Categories;

public static class DependencyContainer
{
    public static IServiceCollection AddCategoriesModels(this IServiceCollection services)
    {
        services.AddScoped<IGetAllCategoriesModel, GetAllCategoriesModel>();
        
        return services;
    }
        
}