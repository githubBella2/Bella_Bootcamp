// membuat file baru denga streamwriter
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        #region BY INPUT
        // StreamWriter sw = new StreamWriter("MyFile.txt");
        // System.Console.WriteLine("Enter text you want write on file: ");
        // string str = Console.ReadLine();
        // sw.Write(str);
        // sw.Flush();
        // sw.Close();
        // Console.ReadKey();
        #endregion

        string file = "MyFile2.txt";
        int a, b, result;
        a = 15;
        b = 20;
        result = a + b;
        using (StreamWriter writer = new StreamWriter(file))
        {
            writer.Write("Sum of {0} + {1} = {2}", a, b, result);
        }
        System.Console.WriteLine("Saved");
        Console.ReadKey();


    }
}