namespace Catalog;

[ApiController]
[Route("/api/catalog/[controller]")]
internal class BrandsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAllAsync() => Ok();
}
