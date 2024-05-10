namespace Poject_A4;

public static class Swap
{
    public static void SwapMethod<T>( ref T x, ref T y)
    {
        T swap = x;
        x = y;
        y = swap;
    }
}
