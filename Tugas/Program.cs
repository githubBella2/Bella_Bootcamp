// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

class Program
{
    //Func atau Action
    static void Main(string[] args)
    {
        Action<int> printFooBar = (n) =>
        {
            for (int i = 0; i <= n; i++)
            {
                if (i % 3 == 0)
                {
                    System.Console.WriteLine("foo");
                }
                else if (i % 5 == 0)
                {
                    System.Console.WriteLine("bar");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    System.Console.WriteLine("foobar");
                }
                else
                {
                    System.Console.WriteLine(i);
                }


            }
        };

        Console.Write("User input => ");
        int n = Convert.ToInt32(Console.ReadLine());

        printFooBar(n);


    }
    // public static void GetNumbers(int num)
    // {
    //     for (int i = 0; i <= num; i++)
    //     {
    //         if (i % 3 == 0)
    //         {
    //             System.Console.WriteLine("foo");
    //         }
    //         else if (i % 5 == 0)
    //         {
    //             System.Console.WriteLine("bar");
    //         }
    //         else if (i % 3 == 0 && i % 5 == 0)
    //         {
    //             System.Console.WriteLine("foobar");
    //         }
    //         else
    //         {
    //             System.Console.WriteLine(i);
    //         }

    //     }
    // }



}
