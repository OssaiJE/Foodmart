using Foodmart.Models;

namespace Foodmart.Interfaces;

public interface IFood {
    void CreateFood(FoodModel food);
    FoodModel GetFood(Guid id);
}