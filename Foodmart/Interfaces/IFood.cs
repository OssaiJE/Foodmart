using ErrorOr;
using Foodmart.Models;
using Foodmart.Services;

namespace Foodmart.Interfaces;

public interface IFood {
    ErrorOr<Created> CreateFood(FoodModel food);
    ErrorOr<Deleted> DeleteFood(Guid id);
    ErrorOr<FoodModel> GetFood(Guid id);
    ErrorOr<UpsertedFood> UpsertFood(FoodModel food);
}