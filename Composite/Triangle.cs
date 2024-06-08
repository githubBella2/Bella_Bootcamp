namespace Composite;

public class Triangle :IShape
{
    public void Draw(string fillColor)
    {
        Console.WriteLine($"Drawing Triangle with color {fillColor}");
    }
}
