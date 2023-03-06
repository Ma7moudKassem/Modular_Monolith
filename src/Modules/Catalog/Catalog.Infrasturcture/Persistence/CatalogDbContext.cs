namespace Catalog.Infrasturcture;

public class CatalogDbContext : BaseDbContext, ICatalogDbContext
{
    protected override string Schema => "Catalog";
    public CatalogDbContext(DbContextOptions<CatalogDbContext> options) : base(options) { }

    public DbSet<Brand> Brands { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
