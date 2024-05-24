// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
class Program
{
    static void Main(string[] args)
    {
        try
        {
            string a = "3a";
            int b = int.Parse(a);
        }
        catch (FormatException e)
        {
            System.Console.WriteLine("Format exception");
        }
        finally
        {
            System.Console.WriteLine("Program closed");
        }
    }
}