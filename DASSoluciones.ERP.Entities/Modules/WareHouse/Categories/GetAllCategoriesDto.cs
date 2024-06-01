namespace DASSoluciones.ERP.Entities.WareHouse.Categories;

public class GetAllCategoriesDto(int id, string name, string? description, bool state)
{
    public int Id => id;
    public string Name => name;
    public string? Description => description;
    public bool State => state;
}