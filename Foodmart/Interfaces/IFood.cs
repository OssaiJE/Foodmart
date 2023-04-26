using ErrorOr;
using Foodmart.Models;

namespace Foodmart.Interfaces;

public interface IFood {
    ErrorOr<Created> CreateFood(FoodModel food);
    ErrorOr<Deleted> DeleteFood(Guid id);
    ErrorOr<FoodModel> GetFood(Guid id);
    ErrorOr<Updated> UpsertFood(FoodModel food);
}