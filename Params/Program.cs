// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using Params;
class Program
{
    static void Main(string[] args)
    {
        Calculator clc = new();
        int hasil = clc.Add(1, 2);
        System.Console.WriteLine(hasil);

        // Calculator clcc = new();
        // clcc.Add("1", "2", "3");

        Calculator clcc = new();
        int hasil2 = clcc.CalculatorString("1", "2", "3", "4", "5");
        System.Console.WriteLine(hasil2);

        Greet greet = new();
        greet.Menyapa("Bayu","Bila");



    }


}