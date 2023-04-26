using ErrorOr;
using Foodmart.Interfaces;
using Foodmart.Models;
using Foodmart.ServiceErrors;

namespace Foodmart.Services;

public class FoodService : IFood
{
    private static readonly Dictionary<Guid, FoodModel> _food = new();
    public ErrorOr<Created> CreateFood(FoodModel food)
    {
        _food.Add(food.Id, food);

        return Result.Created;
    }

    public ErrorOr<Deleted> DeleteFood(Guid id)
    {
        _food.Remove(id);

        return Result.Deleted;
    }

    public ErrorOr<FoodModel> GetFood(Guid id)
    {
        if (_food.TryGetValue(id, out var food))
        {
            return food;
        }
        return Errors.FoodError.NotFound;
    }

    public ErrorOr<UpsertedFood> UpsertFood(FoodModel food)
    {
        var IsNewlyCreated = !_food.ContainsKey(food.Id);
        _food[food.Id] = food;

        return new UpsertedFood(IsNewlyCreated);
    }

}