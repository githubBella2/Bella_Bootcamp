// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        string text = String.Empty;
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        for (int i = 0; i < 100000; i++)
        {
            text += "a";
            text += "b";
            text += text.Replace('a', 'c');
        }
        stopwatch.Stop();
        System.Console.WriteLine(stopwatch.ElapsedMilliseconds);
    }
}
