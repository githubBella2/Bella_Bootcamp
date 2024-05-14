// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.Collections;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        // LIST
        List<string> bp = new() { "Lia", "Jennie" };
        // ENUMERATOR
        IEnumerator<string> enumerator = bp.GetEnumerator();
        while (enumerator.MoveNext())
        {
            System.Console.WriteLine(enumerator.Current);
        }


    }
}

// ITERATOR
public static IEnumerable<int> GetNumbers()
{
    for (int i = 0; i < 100; i++)
    {
        yield return i;
    }
}