namespace ConsoleApp7;
public class OfficeBuilding : Building, IRentable
{
    public int OfficeCount { get; set; }
    public decimal RentPerOffice { get; set; } = 1200; // hər ofis üçün kirayə

    public OfficeBuilding(int id, string name, int officeCount)
        : base(id, name)
    {
        OfficeCount = officeCount;
    }

    public override decimal CalculateMonthlyFee()
    {
        return OfficeCount * 100;
    }

    public decimal GetRent()
    {
        return OfficeCount * RentPerOffice;
    }

    public string GetContractInfo()
    {
        return $"Office Rent Contract: {OfficeCount} offices, Total Rent: {GetRent()} ₼";
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Offices: {OfficeCount}");
        Console.WriteLine($"Monthly Fee: {CalculateMonthlyFee()} ₼");
        Console.WriteLine($"Total Rent Income: {GetRent()} ₼");
    }
}
