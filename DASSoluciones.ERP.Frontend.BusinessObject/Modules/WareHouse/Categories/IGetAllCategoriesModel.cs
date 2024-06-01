namespace DASSoluciones.ERP.Frontend.BusinessObject.Modules.WareHouse.Categories;

public interface IGetAllCategoriesModel
{
    Task<IEnumerable<GetAllCategoriesDto>> GetCategoriesAsync();
}