namespace Foodmart.Contracts.Food;

public record UpdateFood(
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<string> Savory,
    List<string> Sweet
);