namespace Person.Infrasturcture;

public class PersonDbContext : BaseDbContext, IPersonDbContext
{
    public PersonDbContext(DbContextOptions<PersonDbContext> options) : base(options) { }

    protected override string Schema => "Person";
    public DbSet<Core.Person> Persons { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
