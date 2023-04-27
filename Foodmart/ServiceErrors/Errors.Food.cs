using ErrorOr;
using Foodmart.Models;

namespace Foodmart.ServiceErrors;

public static class Errors 
{
    public static class FoodError
    {
        public static Error InvalidName => Error.Validation(
            code: "FoodError.InvalidName",
            description: $"Food name must be at least {FoodModel.MinNameLength} and {FoodModel.MaxNameLength} characters long."
        );
        public static Error InvalidDesc => Error.Validation(
            code: "FoodError.InvalidDesc",
            description: $"Food description must be at least {FoodModel.MinDescLength} and {FoodModel.MaxDescLength} characters long."
        );
        public static Error NotFound => Error.NotFound(
            code: "FoodError.NotFound",
            description: "Food not found."
        );
    }
}