// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using Tugas;
class Program
{
    //Func atau Action
    static void Main(string[] args)
    {
        QueueClass queue = new QueueClass();
        DictionaryClass dictionary = new DictionaryClass();

        System.Console.WriteLine("Masukkan nilai n: ");

        if (int.TryParse(Console.ReadLine(), out int n))
        {
            for (int i = 0; i < n; i++)
            {
                if (dictionary.ContainsKey(i))
                {
                    queue.Enqueue(dictionary.GetValue(i));
                }
                else
                {
                    queue.Enqueue(i.ToString());
                }
            }
            // PrintFooBar(n);
             queue.PrintQueue();
        }
        else
        {
            System.Console.WriteLine("Input tidak valid. Masukkan bilangan bulat ");

        }


    }

    // static void PrintFooBar(int n)
    // {
    //     Queue<string> queue = new Queue<string>();
    //     for (int i = 0; i < n; i++)
    //     {
    //         if ((i + 1) % 3 == 0 && (i + 1) % 5 == 0)
    //         {
    //             queue.Enqueue("foobar");
    //         }
    //         else if ((i + 1) % 3 == 0)
    //         {
    //             queue.Enqueue("foo");
    //         }
    //         else if ((i + 1) % 5 == 0)
    //         {
    //             queue.Enqueue("bar");
    //         }
    //         else
    //         {
    //             queue.Enqueue(i.ToString());
    //         }
    //     }

    //     // Menampilkan isi queue sebagai urutan output
    //     for (int i = 0; i < n; i++)
    //     {
    //         Console.Write(queue.Dequeue());
    //         if (i < n - 1)
    //         {
    //             Console.Write(", ");
    //         }
    //     }
    //     Console.WriteLine();
    // }

}
