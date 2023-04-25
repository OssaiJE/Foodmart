using ErrorOr;
using Foodmart.Models;

namespace Foodmart.Interfaces;

public interface IFood {
    void CreateFood(FoodModel food);
    void DeleteFood(Guid id);
    ErrorOr<FoodModel> GetFood(Guid id);
    void UpsertFood(FoodModel food);
}