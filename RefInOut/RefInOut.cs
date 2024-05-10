namespace RefInOutSpace;

public static class RefInOut
{
    // private readonly int firtNum;
    public static void Multiply(in int a, in int b, out int result)
    {
        result = a * b;
    }
    // public static void Ball(ref int r, in int pi, out hasil )
    // {
    //     hasil = pi * r * r;
    // }
}
