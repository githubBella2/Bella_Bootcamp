// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

class Program
{
    static void Main(string[] args)
    {
        Calculator cal = new();
        // cal.Add(2,2);
        // cal.Add(2.2,4);

        Cat caty = new();
        caty.MakeSound();

        // explicit casting
        ((Animal)caty.MakeSound());

        // BOXING
        int a = 10;
        object b;
        b = a;

        // UNBOXING
        int c;
        c = (int)b;
    }
}

StringBuilder sb = new StringBuilder();
for (int i = 0; i < 10; i++)
{
    sb.Append("Data" + i);
}

string result = sb.ToString();
Console.WriteLine(result);

result = "Monalisa";

public class Calculator
{ //Overloading
    public int Add(int a, int b)
    {
        return a + b;
    }
    public double Add(double a, double b)
    {
        return a + b;
    }
}

class Animal
{
    public virtual void MakeSound()
    {
        System.Console.WriteLine("Animal make sound");
    }
}

class Cat : Animal
{
    // Override makesound
    public override void MakeSound()
    {
        base.MakeSound(); //Memanggil orang tuanya
        Console.WriteLine("Meow");
    }
}

interface IShape
{

}



