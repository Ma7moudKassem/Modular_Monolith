using Catalog.Core;
using Catalog.Core.Abstractions;
using Microsoft.EntityFrameworkCore;
using Shared.Infrastructure;

namespace Catalog.Infrasturcture;

public class CatalogDbContext : BaseDbContext, ICatalogDbContext
{
    public CatalogDbContext(DbContextOptions options) : base(options) { }

    public DbSet<Brand> Brands { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
