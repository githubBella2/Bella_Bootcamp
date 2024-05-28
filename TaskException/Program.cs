// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
class Program
{
    // static async void Main(string[] args)
    static async Task Main(string[] args)
    {
        // try
        // {
        //     Task task = Task.Run(() => ExceptionMaker());
        //     task.Wait();
        // }
        // catch (System.Exception e)
        // {
        //     System.Console.WriteLine(e.Message);
        // }

        #region COBA
        // try
        // {
        //     Task<int> calculate = CalculateAsync();
        //     // Menunggu hasil dari tugas
        //     int result = await calculate;
        //     Console.WriteLine($"Result: {result}");
        // }
        // catch (System.Exception)
        // {
        //     throw;
        // }
        #endregion

        #region EXCEPTION
        try
        {
            Task task3 = Task.Run(()=>ExceptionMaker3());
            Task task4 = Task.Run(()=>ExceptionMaker4());
            Task.WaitAll(task3,task4);
        }
        catch (System.Exception e)
        {
            
            System.Console.WriteLine(e.Message);
        }
        #endregion

    }
    static void ExceptionMaker()
    {
        throw new FormatException("Exception thrown from ExceptionMaker");
    }

    #region COBA
    static async Task<int> CalculateAsync()
    {
        try
        {
            await Task.Run(() =>
            {
                throw new InvalidOperationException("Invalid Operation");
            });
            return 1;
        }
        catch (System.Exception ex)
        {

            throw ex;
        }
        // Menggunakan Task.Run untuk menjalankan kode secara asinkron

    }
    #endregion

    static void ExceptionMaker3()
    {
        throw new FormatException("Exception thrown from ExceptionMaker");
    }
    static void ExceptionMaker4()
    {
        throw new FormatException("Exception thrown from ExceptionMaker");
    }
}
