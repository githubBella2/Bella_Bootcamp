// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// using System.Runtime.InteropServices;
class Program
{
    static void Main(string[] args)
    {
        // FORMAT EXCEPTION
        string a = "Nana88";
        // System.Console.WriteLine(result);

        try
        {
            int result = int.Parse(a);

        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }

        // DIVIDED BY ZERO EXCEPTION
        int x = 10, y = 0;
        // System.Console.WriteLine(result);
        try
        {
            int result = x / y;

        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine(ex.Message);

        }

        // ARRAY EXCEPTION
        int[] someArray = { 1, 2, 3, 4 };
        try
        {
            System.Console.WriteLine(someArray[4]);
        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine(ex.Message);

        }

        // NULL
        string nama = null;
        try
        {
            System.Console.WriteLine(nama.Length);
        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }

        //Stack Overflow
        static void Run()
        {
            Run();
        }
        try
        {
            Run();
        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }
    
    
    }
}