namespace ConsoleApp7
{
    public class Program
    {
    static void Main()
    {
        Console.WriteLine("Started: ");

        ApartmentBuilding apt = new ApartmentBuilding(1, "Baxca Seher", 40);
        OfficeBuilding office = new OfficeBuilding(2, "Residance", 25);

        Console.WriteLine("Apartment Info: ");
        apt.ShowInfo();
        Console.WriteLine($"Rent: {apt.GetRent().ToCurrencyText()}");
        Console.WriteLine(apt.GetContractInfo());

        Console.WriteLine("Office Info: ");
        office.ShowInfo();
        Console.WriteLine($"Rent: {office.GetRent().ToCurrencyText()}");
        Console.WriteLine(office.GetContractInfo());

        Console.WriteLine($"Total Buildings Registered: {Registry.TotalBuildings}");

        Console.WriteLine("Extension Method: ");
        decimal price = 1500.75m;
        Console.WriteLine(price.ToCurrencyText()); 
    }
}

}
