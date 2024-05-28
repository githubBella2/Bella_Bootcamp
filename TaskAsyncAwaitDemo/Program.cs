// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
class Program
{
    static async Task Main(string[] args)
    {
        // Add(2, 3);
        int sum = await Add(2, 3);

        System.Console.WriteLine(sum);
    }

    static async Task<int> Add(int a, int b)
    {
        return await Task.FromResult(a+b);

        //     await Task.Run(() =>
        //    {
        //        return a + b;
        //    });

    }

}