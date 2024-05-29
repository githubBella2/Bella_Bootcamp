using System.Text;

class Program
{
    static void Main(string[] args)
    {
        using (FileStream fs = new FileStream("test1.txt", FileMode.Create, FileAccess.Write, FileShare.None))
        {
            string text = "Selamat pagi, saya agak lapar";
            byte[] myBytes = new byte[text.Length]; //buffer

            myBytes = Encoding.UTF8.GetBytes(text);
            fs.Write(myBytes, 0, myBytes.Length);
            System.Console.ReadLine();
        }
        System.Console.ReadLine();
        System.Console.WriteLine();

        using (FileStream fs1 = File.OpenRead("test1.txt"))
        {
            byte[] b = new byte[1024];
            UTF8Encoding temp = new UTF8Encoding(true);
            int readLen;
            while ((readLen = fs1.Read(b, 0, b.Length)) > 0)
            {
                System.Console.WriteLine(temp.GetString(b, 0, readLen));
            }
        }

        // membuka filedengan stream reader
        using (var sr = new StreamReader("test1.txt"))
        {
            System.Console.WriteLine(sr.ReadToEnd());
        }
    }
}