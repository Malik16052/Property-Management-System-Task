namespace ConsoleApp7;

public class ApartmentBuilding : Building, IRentable
{
    public int ApartmentCount { get; set; }
    public decimal RentPerApartment { get; set; } = 600;

    public ApartmentBuilding(int id, string name, int apartmentCount)
        : base(id, name)
    {
        ApartmentCount = apartmentCount;
    }

    public override decimal CalculateMonthlyFee()
    {
        return ApartmentCount * 50;
    }

    public decimal GetRent()
    {
        return ApartmentCount * RentPerApartment;
    }

    public string GetContractInfo()
    {
        return $"Apartment Rent: {ApartmentCount}, Total Rent: {GetRent()}";
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Apartments: {ApartmentCount}");
        Console.WriteLine($"Monthly Fee: {CalculateMonthlyFee()}");
        Console.WriteLine($"Total Rent Income: {GetRent()}");
    }
}


