// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

class Program
{
    //Func atau Action
    static void Main(string[] args)
    {
        System.Console.WriteLine("Masukkan angka: ");
        int num = Convert.ToInt32(Console.ReadLine());
        // GetNumbers(num);

        GetNumbers(num, i => Console.WriteLine(i % 3 == 0 ? "Foo":i.ToString()));

        // foreach (var foo in GetNumbers(num))
        // {
        //     System.Console.WriteLine(foo);
        // }


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

    public static void GetNumbers(int n, Action<int> action)
    {
        for (int i = 0; i <= n; i++)
        {
            if (i % 3 == 0)
            {
                action(i);
            }
            else if (i % 5 == 0)
            {
                action(i);
            }
            else if (i % 3 == 0 && i % 5 == 0)
            {
                action(i);
            }
            else
            {
                action(i);
            }
        }
    }
}
