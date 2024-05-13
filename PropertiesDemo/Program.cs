// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using PropertiesDemo;
class Program
{
    static void Main(string[] args)
    {
        Human hm = new();
        // hm.Balance = 3000; // Tidak bisa.

        System.Console.WriteLine("Balance1: " + hm.Balance);
        int result = hm.setBalance(-1);
        System.Console.WriteLine("Balance2: " + hm.Balance);
        System.Console.WriteLine(result);
    }
}