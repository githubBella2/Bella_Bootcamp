// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using Kucing;

class Program
{
    static void Main()
    {
        Cat caty = new Cat("Fish","Caty");
        Cat catytu = new Cat("Sawi","CatyTU");
        Cat catyta = new Cat("Kimchi","CatyTA");
        caty.Eat();
        catyta.Eat();
        catytu.Eat();
        // caty.Eat();
        // caty.PrintInfo();

    }
}

