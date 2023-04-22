using Foodmart.Interfaces;
using Foodmart.Models;

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

    public FoodModel GetFood(Guid id)
    {
        return _food[id];
    }

    public void UpsertFood(FoodModel food)
    {
        _food[food.Id] = food;
    }

}