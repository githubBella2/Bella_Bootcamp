// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using StaticDemo;
class Program
{
    static void Main(string[] args)
    {
        double tambah = Calculator.Add(2, 5);
        double kurang = Calculator.Substract(3, 4);
        double toFahrenheit = Calculator.CelciusToFahrenheit(45);
        System.Console.WriteLine($"Static penjumlahan: {tambah}");
        System.Console.WriteLine($"Static pengurangan: {kurang}");
        System.Console.WriteLine($"Static suhu Celc ke Fahrenheit: {toFahrenheit}");
        // Calculator.Pi;

        string msg = "GoOd MoRning";
        System.Console.WriteLine(MethodExtensions.ToUpper(msg));

    }
}
