namespace DelegateDemo;

public delegate void DelegateMethod(); //alias dari method
public static class MyDelegate 
{
    public static void Print()
    {
        System.Console.WriteLine("Selamat Pagi");
    }

    public static void Run()
    {
        System.Console.WriteLine("RUNN");
    }
}
