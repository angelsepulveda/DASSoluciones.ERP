namespace DASSoluciones.ERP.Backend.BusinessObject.Modules.WareHouse.Categories.Features.Interfaces;

public interface IGetAllCategoriesOutputPort
{
    IEnumerable<GetAllCategoriesDto> Categories { get; }

    Task HandleResultAsync(IEnumerable<GetAllCategoriesDto> categories);
}