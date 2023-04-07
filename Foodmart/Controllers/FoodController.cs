using Foodmart.Contracts.Food;
using Microsoft.AspNetCore.Mvc;

namespace Foodmart.Controllers;

[ApiController]
public class FoodController : ControllerBase
{
    [HttpPost("/food")]

    public IActionResult CreateFood(CreateFood request)
    {
        return Ok();
    }
}
