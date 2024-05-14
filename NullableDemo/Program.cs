// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
class Program
{
    static void Main(string[] args)
    {
        int? a = null;

        // Generic dengan tipe nullable
        Nullable<int> nullableInt = null;
        int? nullableIntt = null;
        // 

        if (a.HasValue)
        {
            System.Console.WriteLine($"a is: {a}");
        }
        else
        {
            System.Console.WriteLine("a doesn't have value");
        }
    }
}