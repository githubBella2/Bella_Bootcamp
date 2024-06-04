namespace TestingDemo;

public class Rectangle : IShape
{
    public double Height { get; set; }
    public double Width { get; set; }

    // memanggil dari class AreaCalculator
    public double CalculateArea()
    {
        return Width * Height;
    }
}
