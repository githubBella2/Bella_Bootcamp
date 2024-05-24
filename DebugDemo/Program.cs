// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        int a = 9;
        int b = 11;
        Matematika mat= new();
        // mat.Add(a, b);
        // System.Console.WriteLine(mat.Add(a,b));
        mat.Add(10,2);


    }

}
class Matematika
{
    public void Add(int a, int b)
    {int res;
        // return a + b;
        for (int i = 0; i < 10; i++)
        {
            res=a+b+i;
            System.Console.WriteLine(res);
        //    System.Console.WriteLine(a+b+i);
        }
        // return a+b;
    }
}
