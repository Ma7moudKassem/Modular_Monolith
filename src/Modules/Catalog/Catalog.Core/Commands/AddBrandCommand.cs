namespace Catalog.Core;

public class AddBrandCommand : IRequest<int>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Detail { get; set; }
}
