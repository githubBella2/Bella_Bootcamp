// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        ConsoleTraceListener consoleTrace = new();
        TextWriterTraceListener textWriterTraceListener = new("trace.log");
        Trace.Listeners.Add(consoleTrace);
        Trace.Listeners.Add(textWriterTraceListener);
        Trace.WriteLine("Start the program");
        // Trace.Flush();
    }
}