// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
class Program
{
    static void Main(string[] args)
    {
        Thread thread = new Thread(() =>
        {
            try
            {
                Thread.Sleep(5000);
                // throw new Exception("Error");
                ExceptionMaker3();
                ExceptionMaker4();

            }
            catch (System.Exception e)
            {

                System.Console.WriteLine("Exception caught: " + e.Message);
            }
        });
        thread.Start();
        System.Console.WriteLine("Finished");
    }


    static void ExceptionMaker3()
    {
        throw new FormatException("Exception thrown from ExceptionMaker");
    }
    static void ExceptionMaker4()
    {
        throw new FormatException("Exception thrown from ExceptionMaker4");
    }
}