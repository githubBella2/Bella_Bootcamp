// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");




using FileManager;

class Program
{
    static void Main(string[] args)
    {
        string fileName="Fileku.txt";
        FileManagerClass fm = new();
        fm.Write(fileName,"Wassup Winata");
    }
}
