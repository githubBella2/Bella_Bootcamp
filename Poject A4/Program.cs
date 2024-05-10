// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using Poject_A4;
class Program
{
    static void Main(string[] args)
    {
        Extensions.Cetak("Extension");
        
        int a = 3;
        int b = 5;
        Swap.SwapMethod<int>(ref a, ref b);
        System.Console.WriteLine(a);
        System.Console.WriteLine(b);
        System.Console.WriteLine("\n");

        bool IsEqual = Calculator.AreEqual<double>(10.5, 20.5);
        if (IsEqual)
        {
            System.Console.WriteLine("Both are Equal");
        }
        else
        {
            System.Console.WriteLine("Both are Not Equal");
            System.Console.WriteLine("\n");

        }

        // Inisiasi GenericClass, string is the type argument
        GenericClass<string, int> myGenericClass = new GenericClass<string, int>
        {
            Message = "Welcome to Bootcamp"
        };
        myGenericClass.GenericMethod("Dewi Idda", "Salatiga", 25);
        System.Console.WriteLine("\n");

        System.Console.WriteLine("Generic Method Example");
        myGenericClass.GenericMethodParameter<int, int>(10, 20);
        myGenericClass.GenericMethodParameter<double, string>(10.5, "Hello");
        myGenericClass.GenericMethodParameter<string, float>("Bella", 20.5f);
        Console.ReadLine();
        System.Console.WriteLine("\n");

        // Generic Struct
        GenericConstraintStruct<int> intClass = new GenericConstraintStruct<int>();
        intClass.Message = 10;
        intClass.GeneridMethodStruct(10, 20);
        Console.ReadLine();


    }
}
