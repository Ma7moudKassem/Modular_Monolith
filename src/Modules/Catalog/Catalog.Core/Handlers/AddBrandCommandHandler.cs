using Catalog.Core.Abstractions;

namespace Catalog.Core;

public class AddBrandCommandHandler : IRequestHandler<AddBrandCommand,int>
{
    ICatalogDbContext _context;
    public AddBrandCommandHandler(ICatalogDbContext context)
    {
        _context = context;
    }
    public async Task<int> Handle(AddBrandCommand request, CancellationToken cancellationToken)
    {
        Brand brand = new()
        {
            Id = request.Id,
            Name = request.Name,
            Detail = request.Detail,
        };

        await _context.Brands.AddAsync(brand, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);

        return brand.Id;
    }
}
