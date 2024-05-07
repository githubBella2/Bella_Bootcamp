namespace Vehicle;

public class Wheel
{
    public string wheelType;
    public int wheelYear;
    public string wheelBrand;

    public Wheel(string wheelType, int wheelYear, string wheelBrand)
    {
        this.wheelType = wheelType;
        this.wheelYear = wheelYear;
        this.wheelBrand = wheelBrand;
    }

    public viud PrintAttribute()
    {
        Console.WriteLine($"The Wheel type is {wheelType}");
        Console.WriteLine($"The wheel year is {wheelYear}");
        Console.WriteLine($"The wheel brand is {wheelBrand}");
    }

    
}
