using Foodmart.Interfaces;
using Foodmart.Models;

namespace Foodmart.Services;

public class FoodService : IFood
{
    private readonly Dictionary<Guid, FoodModel> _food = new();
    public void CreateFood(FoodModel food)
    {
        _food.Add(food.Id, food);
    }
}