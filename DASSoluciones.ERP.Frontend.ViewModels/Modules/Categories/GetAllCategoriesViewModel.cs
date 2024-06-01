namespace DASSoluciones.ERP.Frontend.ViewModels.Modules.Categories;

public class GetAllCategoriesViewModel(IGetAllCategoriesModel model)
{
    public IEnumerable<GetAllCategoriesDto> Categories { get; private set; } = new List<GetAllCategoriesDto>();
    public async Task GetAllCategoriesAsync()
    {
        Categories = await model.GetCategoriesAsync();
    }
}