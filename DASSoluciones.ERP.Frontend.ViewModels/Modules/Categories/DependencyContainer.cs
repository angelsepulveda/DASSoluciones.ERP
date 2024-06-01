

namespace DASSoluciones.ERP.Frontend.ViewModels.Modules.Categories;

public static class DependencyContainer
{
    public static IServiceCollection AddCategoriesViewModels(this IServiceCollection services)
    {
        services.AddScoped<GetAllCategoriesViewModel>();
        
        return services;
    }
}