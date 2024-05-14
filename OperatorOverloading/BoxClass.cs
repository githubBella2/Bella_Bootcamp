namespace OperatorOverloading;

public class BoxClass
{
    public int Length { get; set; }
    public int Width { get; set; }

    public BoxClass(int length, int width)
    {
        Length = length;
        Width = width;
    }

    // Operator Overloading
    public static BoxClass operator +(BoxClass b1, BoxClass b2)
    {
        int panjang = b1.Length + b2.Length;
        int lebar = b1.Width + b2.Width;
        BoxClass box = new(panjang, lebar);
        return box;
    }
}
