namespace Foodmart.Contracts.Food;

public record CreateFood(
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<string> Savory,
    List<string> Sweet
);