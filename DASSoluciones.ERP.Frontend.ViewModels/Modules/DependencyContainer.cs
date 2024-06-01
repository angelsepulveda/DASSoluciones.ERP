namespace DASSoluciones.ERP.Frontend.ViewModels.Modules;

public static class DependencyContainer
{
    public static IServiceCollection AddModulesViewModels(this IServiceCollection services)
    {
        services.AddCategoriesViewModels();
        
        return services;
    }
}