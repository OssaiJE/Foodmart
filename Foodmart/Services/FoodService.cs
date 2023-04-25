using ErrorOr;
using Foodmart.Interfaces;
using Foodmart.Models;
using Foodmart.ServiceErrors;

namespace Foodmart.Services;

public class FoodService : IFood
{
    private static readonly Dictionary<Guid, FoodModel> _food = new();
    public void CreateFood(FoodModel food)
    {
        _food.Add(food.Id, food);
    }

    public void DeleteFood(Guid id)
    {
        _food.Remove(id);
    }

    public ErrorOr<FoodModel> GetFood(Guid id)
    {
        if (_food.TryGetValue(id, out var food))
        {
            return food;
        }
        return Errors.FoodError.NotFound;
    }

    public void UpsertFood(FoodModel food)
    {
        _food[food.Id] = food;
    }

}