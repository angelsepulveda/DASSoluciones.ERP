namespace DASSoluciones.ERP.Frontend.WebApiProxies.Modules.WareHouse.Categories;

internal class GetAllCategoriesModel : IGetAllCategoriesModel
{
    IEnumerable<GetAllCategoriesDto> _categories =
    [
        new(1, "Category 1", "description 1", true),
    ];


    public async Task<IEnumerable<GetAllCategoriesDto>> GetCategoriesAsync() => await Task.FromResult(_categories);
}