namespace Vehicle;

public class Engine
{
    public string engineType;
    public int engineHP;
    public string engineBrand;

    public Engine(string engineType, int engineHP, string engineBrand)
    {
        this.engineType = engineType;
        this.engineHP = engineHP;
        this.engineBrand = engineBrand;
    }

    public void PrintAttribute(string engineType, int engineHP, string engineBrand)
    {
        Console.WriteLine($"The engine type is {engineType}");
        
    }
}
