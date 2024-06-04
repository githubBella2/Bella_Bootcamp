namespace TestingDemo;

public class PrintShape
{
    public void PrintShapeResult(IShape shape)
    {
        var result= shape.CalculateArea();
        System.Console.WriteLine(result);
    }
}
