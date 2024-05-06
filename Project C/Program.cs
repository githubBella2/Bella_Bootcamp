// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using Buku;
class Program()
{
    static void Main()
    {
        Book book = new Book();
        int luas = book.Total(3,100);
        Console.WriteLine(luas);
    }
}

