// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string result = null;
        int iteration = 10000;
        for (int i = 0; i < iteration; i++)
        {
            result += "Hello";
            result += "World";
        }
    }
}
