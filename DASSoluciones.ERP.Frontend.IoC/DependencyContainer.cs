namespace DASSoluciones.ERP.Frontend.IoC;

public static class DependencyContainer
{
    public static IServiceCollection AddErpServices(this IServiceCollection services)
    {
        services.AddModels();
        services.AddViewModels();

        return services;
    }
}