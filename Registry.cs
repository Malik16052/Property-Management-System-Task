namespace ConsoleApp7;

internal class Registry
{
    private static int _totalBuildings=0;
    public static int TotalBuildings { get; }


    static Registry()
    {
        Console.WriteLine("Yeni bina yaradilir..");
    }
    public static void Register(Building b)
    {
        _totalBuildings++;
        Console.WriteLine($"Registered: {b.Name} ID: {b.Id} — Total Buildings: {_totalBuildings}");
    }



}
