namespace TestingDemo;

public class AreaCalculator
{
    //contoh yang menyalahi aturan SOLID
    // public double CalculateArea(object shape)
    // {
    //     if (shape is Rectangle)
    //     {
    //         Rectangle rect = (Rectangle)shape; //di casting krn dia object
    //         return rect.Height * rect.Width;
    //     }
    //     else if (shape is Circle)
    //     {
    //         Circle circle = (Circle)shape;
    //         return circle.Radius * circle.Radius * Math.PI;
    //     }
    //     return 0;
    // }
}
