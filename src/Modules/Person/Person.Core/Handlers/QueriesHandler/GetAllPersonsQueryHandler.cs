namespace Person.Core;

public class GetAllPersonsQueryHandler : IRequestHandler<GetAllPersonsQuery, IEnumerable<Person>>
{
    IPersonDbContext _context;
    public GetAllPersonsQueryHandler(IPersonDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Person>> Handle(GetAllPersonsQuery request, CancellationToken cancellationToken)
    {
        IEnumerable<Person> persons = await _context.Persons.ToListAsync();
        
        if (persons is null) throw new ArgumentNullException(nameof(persons));
        
        return persons;
    }
}
