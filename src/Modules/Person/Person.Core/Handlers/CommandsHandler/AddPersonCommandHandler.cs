namespace Person.Core;

public class AddPersonCommandHandler : IRequestHandler<AddPersonCommand, int>
{
    IPersonDbContext _context;
    public AddPersonCommandHandler(IPersonDbContext context)
    {
        _context = context;
    }
    public async Task<int> Handle(AddPersonCommand request, CancellationToken cancellationToken)
    {
        Person person = new()
        {
            Id = request.Id,
            Name = request.Name,
        };

        await _context.Persons.AddAsync(person, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);

        return person.Id;
    }
}
