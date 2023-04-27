using ErrorOr;
using Foodmart.ServiceErrors;

namespace Foodmart.Models;

public class FoodModel
{
    public const int MinNameLength = 3;
    public const int MaxNameLength = 50;
    public const int MinDescLength = 30;
    public const int MaxDescLength = 150;
    public Guid Id { get; }
    public string Name { get; }
    public string Description { get; }
    public DateTime StartDateTime { get; }
    public DateTime EndDateTime { get; }
    public DateTime LastModifiedDateTime { get; }
    public List<string> Savory { get; }
    public List<string> Sweet { get; }

    private FoodModel(Guid id, string name, string description, DateTime startDateTime, DateTime endDateTime, DateTime lastModifiedDateTime, List<string> savory, List<string> sweet)
    {
        Id = id;
        Name = name;
        Description = description;
        StartDateTime = startDateTime;
        EndDateTime = endDateTime;
        LastModifiedDateTime = lastModifiedDateTime;
        Savory = savory;
        Sweet = sweet;
    }

    public static ErrorOr<FoodModel> Create(
        string name,
        string description,
        DateTime startDateTime,
        DateTime endDateTime,
        List<string> savory,
        List<string> sweet,
        Guid? id = null
    )
    {
        List<Error> errors = new();

        if ((name.Length < MinNameLength) || (name.Length > MaxNameLength))
        {
            errors.Add(Errors.FoodError.InvalidName);
        }
        if ((description.Length < MinDescLength) || (description.Length > MaxDescLength))
        {
            errors.Add(Errors.FoodError.InvalidDesc);
        }

        if (errors.Count > 0)
        {
            return errors;
        }

        return new FoodModel(
            id ?? Guid.NewGuid(),
            name,
            description,
            startDateTime,
            endDateTime,
            DateTime.UtcNow,
            savory,
            sweet
        );
    }
}