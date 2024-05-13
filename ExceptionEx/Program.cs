// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            // ExceptionMaker();
            ExceptionMaker2();
        }
        catch (IndexOutOfRangeException e)
        {

            System.Console.WriteLine(e.Message);
        }
        catch (DivideByZeroException e)
        {
            System.Console.WriteLine(e.Message);

        }
        catch (IOException e)
        {
            System.Console.WriteLine(e.Message);

        }
        catch (InvalidOperationException e)
        {
            System.Console.WriteLine(e.Message);

        }
        // finally
        // {
        //     System.Console.WriteLine("Finally");
        // }
    }


    static void ExceptionMaker()
    {
        using (StreamReader sr = new StreamReader("file.txt"))
        {
            string line = sr.ReadLine();
            System.Console.WriteLine("Isi file: " + line);
        }
    }

    static void ExceptionMaker2()
    {
        int[] numbers = new int[3];
        int index = 5;
        int value = numbers[index];
    }



}

