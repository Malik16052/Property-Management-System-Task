using System.Xml.Linq;

public record Property(int Id, string Address, decimal Area, int FloorCount ,bool HasGarage);
public abstract class Building
{
    int Id { get; init; }
    string Name { get; set; }

    protected Building(int id, string name)
    {
        Id = id;
        Name = name;

        Registry.Register(this);

    }

    public abstract decimal CalculateMonthlyFee();
    public virtual void ShowInfo()
    {
        Console.WriteLine($"Id:{Id} Name:{Name}");
    }
}

public static class BuildingExtensions
{
    public static string ToCurrencyText(this decimal value)
    {
        return $"{value} AZN";
    }
}