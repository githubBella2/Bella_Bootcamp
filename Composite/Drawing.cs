namespace Composite;

public class Drawing : IShape
{
    private readonly List<IShape> shapes = new List<IShape>();
    public void Draw(string fillColor)
    {
        foreach (var shape in shapes)
        {
            shape.Draw(fillColor);
        }
    }
    public void Add(IShape shape)
    {
        shapes.Add(shape);
    }
    public void Remove(IShape shape)
    {
        shapes.Remove(shape);
    }
    public void Clear()
    {
        Console.WriteLine("Clearing all the shapes from drawing");
        shapes.Clear();
    }
}
