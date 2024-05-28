// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

class Program
{
    static void Main(string[] args)
    {
        Task<int> task = new Task<int>(ReturnNine);
        task.Start();
        System.Console.WriteLine(task.Result);

        Task<string> task2 = new Task<string>(ReturnHello);
        task2.Start();
        System.Console.WriteLine(task2.Result);



        var task3 = new Task<Dictionary<string, int>>(ReturnDict);
        task3.Start();
        foreach (var item in task3.Result)
        {
            System.Console.WriteLine($"Penduduk: {item.Key}: {item.Value}");
        }
    }
    static int ReturnNine()
    {
        return 9;
    }
    static string ReturnHello()
    {
        return "Hello";
    }
    static Dictionary<string, int> ReturnDict()
    {
        Dictionary<string, int> dict = new();
        dict.Add("Yono", 57);
        dict.Add("Alex", 22);
        return dict;
    }
}