// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using DestructorDemo;

class Program
{
    static void Main(string[] args)
    {
        // Car car= new();
        // Console.ReadKey();
        //  System.Threading.Thread.Sleep(20);
        //  car=null;
        // GC.Collect();

        // GC.WaitForPendingFinalizers();

        InstanceCreator();
        GC.Collect();
        GC.WaitForPendingFinalizers();
        System.Console.WriteLine("Wait for the next order");


    }
    static void InstanceCreator()
    {
        Child child = new();
    }
}