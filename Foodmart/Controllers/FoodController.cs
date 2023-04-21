using Foodmart.Contracts.Food;
using Foodmart.Interfaces;
using Foodmart.Models;
using Microsoft.AspNetCore.Mvc;

namespace Foodmart.Controllers;

[ApiController]
[Route("food")]
// [Route("[controller]")] // Alternatively for above
public class FoodController : ControllerBase
{
    private readonly IFood _foodInterface;

    public FoodController(IFood foodInterface)
    {
        _foodInterface = foodInterface;
    }

    [HttpPost()]
    public IActionResult CreateFood(CreateFood request)
    {
        var food = new FoodModel(
            Guid.NewGuid(),
            request.Name,
            request.Description,
            request.StartDateTime,
            request.EndDateTime,
            DateTime.UtcNow,
            request.Savory,
            request.Sweet
            );

        _foodInterface.CreateFood(food);

        var response = new FoodResponse(
            food.Id,
            food.Name,
            food.Description,
            food.StartDateTime,
            food.EndDateTime,
            food.LastModifiedDateTime,
            food.Savory,
            food.Sweet
        );

        return CreatedAtAction(
            actionName: nameof(GetFood),
            routeValues: new { id = food.Id },
            value: response
            );
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetFood(Guid id)
    {
        FoodModel food = _foodInterface.GetFood(id);
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
