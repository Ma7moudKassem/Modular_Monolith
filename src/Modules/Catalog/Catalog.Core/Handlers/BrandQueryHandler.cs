using Catalog.Core.Abstractions;

namespace Catalog.Core;

public class BrandQueryHandler : IRequestHandler<GetAllBrands, IEnumerable<Brand>>
{
    ICatalogDbContext _context;
    public BrandQueryHandler(ICatalogDbContext catalogDbContext)
    {
        _context = catalogDbContext;
    }
    public async Task<IEnumerable<Brand>> Handle(GetAllBrands request, CancellationToken cancellationToken)
    {
        IEnumerable<Brand> brands = await _context.Brands.ToListAsync();
        if (brands is null) throw new ArgumentNullException(nameof(brands));

        return brands;
    }
}
