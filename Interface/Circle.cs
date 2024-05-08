namespace Interface;

public class Circle :IShape
{
    public void Draw()
    {
        System.Console.WriteLine("Drawing from interface");
    }
    public override void Drawing()
    {
        System.Console.WriteLine("Drwaing from abstract");
    }
}
