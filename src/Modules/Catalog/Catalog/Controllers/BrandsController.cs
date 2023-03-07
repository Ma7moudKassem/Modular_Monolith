using MediatR;

namespace Catalog;

[ApiController]
[Route("/api/catalog/[controller]")]
internal class BrandsController : ControllerBase
{
    IMediator _mediator;
    public BrandsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllBrandsAsync()
    {
        IEnumerable<Brand> brands = await _mediator.Send(new GetAllBrands());

        if (ModelState.IsValid)
            return Ok(brands);

        return BadRequest();
    }

    [HttpPost]
    public async Task<IActionResult> AddBrand(AddBrandCommand command)
    {
        return Ok(await _mediator.Send(command));
    }
}
