// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
class Program
{
    static void Main(string[] args)
    {
    #if DEBUG
        System.Console.WriteLine("DEBUG");
    #endif 
    #if RELEASE
        System.Console.WriteLine("RELEASE");
    #endif
    #if DEVELOPMENT
        System.Console.WriteLine("DEVELOPMENT");
    #endif
    #if TEKOTOK
        System.Console.WriteLine("TEKOTOK");
    #endif
    }

}
