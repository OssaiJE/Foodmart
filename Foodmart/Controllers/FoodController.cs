using ErrorOr;
using Foodmart.Contracts.Food;
using Foodmart.Interfaces;
using Foodmart.Models;
using Foodmart.ServiceErrors;
using Microsoft.AspNetCore.Mvc;

namespace Foodmart.Controllers;

public class FoodController : ApiController
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

        ErrorOr<Created> creatFoodResult = _foodInterface.CreateFood(food);

        if (creatFoodResult.IsError)
        {
            return Problem(creatFoodResult.Errors);
        }

        return CreatedAtAction(
            actionName: nameof(GetFood),
            routeValues: new { id = food.Id },
            value: MapFoodResponse(food)
            );
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetFood(Guid id)
    {
        ErrorOr<FoodModel> getFoodResult = _foodInterface.GetFood(id);

        return getFoodResult.Match(
            food => Ok(MapFoodResponse(food)),
            errors => Problem(errors)
        );
    }

    [HttpPut("{id:guid}")]
    public IActionResult UpdateFood(Guid id, UpdateFood request)
    {
        var food = new FoodModel(
            id,
            request.Name,
            request.Description,
            request.StartDateTime,
            request.EndDateTime,
            DateTime.UtcNow,
            request.Savory,
            request.Sweet
        );
        _foodInterface.UpsertFood(food);
        return NoContent();
    }

    [HttpDelete("{id:guid}")]
    public IActionResult DeleteFood(Guid id)
    {
        _foodInterface.DeleteFood(id);
        return NoContent();
    }

    private static FoodResponse MapFoodResponse(FoodModel food)
    {
        return new FoodResponse(
            food.Id,
            food.Name,
            food.Description,
            food.StartDateTime,
            food.EndDateTime,
            food.LastModifiedDateTime,
            food.Savory,
            food.Sweet
        );
    }
}
