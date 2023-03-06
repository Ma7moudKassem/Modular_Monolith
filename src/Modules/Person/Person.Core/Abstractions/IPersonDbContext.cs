namespace Person.Core;

public interface IPersonDbContext
{
    public DbSet<Person> Persons { get; set; }
    public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
