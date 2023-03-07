namespace Person.Core;

public class AddPersonCommand : IRequest<int>
{
    public int Id { get; set; }
    public string Name { get; set; }
}
