namespace DASSoluciones.ERP.Frontend.RazorViews.Modules.WareHouse.Categories.Components;

public partial class GetAllCategories : ComponentBase
{
    [Inject]
    public GetAllCategoriesViewModel ViewModel { get; set; }
    
    protected override async Task OnInitializedAsync()
    {
        await ViewModel.GetAllCategoriesAsync();
    }
}