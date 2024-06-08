namespace Composite;

public class Circle:IShape
{
    public void Draw(string fillColor)
    {
        Console.WriteLine($"Drawing Circle with color {fillColor}");
    }
}
