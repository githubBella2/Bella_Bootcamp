// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System.Diagnostics;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder text =new();
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        for (int i = 0; i < 1000000; i++)
        {
            text.Append("a");
            text.Append("b");
            text.Append("c");
        }
        stopwatch.Stop();
        System.Console.WriteLine(stopwatch.ElapsedMilliseconds);
    }
}
