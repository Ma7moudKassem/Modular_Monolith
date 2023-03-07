using Catalog.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Person.Core;

namespace Person;

[ApiController]
[Route("/api/[controller]")]
public class PersonController : ControllerBase
{
    IMediator _mediator;
    public PersonController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllPersonAsync()
    {
        IEnumerable<Core.Person> persons = await _mediator.Send(new GetAllPersonsQuery());

        if (ModelState.IsValid)
            return Ok(persons);

        return BadRequest();
    }

    [HttpPost]
    public async Task<IActionResult> AddPerson(AddPersonCommand command)
    {
        return Ok(await _mediator.Send(command));
    }

}
