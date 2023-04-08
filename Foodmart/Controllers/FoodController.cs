using Foodmart.Contracts.Food;
using Microsoft.AspNetCore.Mvc;

namespace Foodmart.Controllers;

[ApiController]
[Route("food")]
// [Route("[controller]")] // Alternatively for above
public class FoodController : ControllerBase
{
    [HttpPost()]
    public IActionResult CreateFood(CreateFood request)
    {
        return Ok(request);
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetFood(Guid id)
    {
        return Ok(id);
    }

    [HttpPut("{id:guid}")]
    public IActionResult UpdateFood(Guid id, UpdateFood request)
    {
        return Ok(request);
    }

    [HttpDelete("{id:guid}")]
    public IActionResult DeleteFood(Guid id)
    {
        return Ok(id);
    }
}
