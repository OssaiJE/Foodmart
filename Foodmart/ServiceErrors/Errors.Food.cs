using ErrorOr;

namespace Foodmart.ServiceErrors;

public static class Errors 
{
    public static class FoodError
    {
        public static Error NotFound => Error.NotFound(
            code: "FoodError.NotFound",
            description: "Food not found."
        );
    }
}