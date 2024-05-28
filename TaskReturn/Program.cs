// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = Enumerable.Range(1, 10).ToList();
        Task<int> totalGenap = JumlahBilGenap(numbers);
        Task<int> totalGanjil = JumlahBilGanjil(numbers);

        Task.WhenAll(totalGenap, totalGanjil);

        // int evenSum =  totalGenap;
        // System.Console.WriteLine($"genap: {totalGenap}");



         // Menunggu hingga kedua tugas selesai
        // await Task.WhenAll(evenSumTask, oddSumTask);

        // int evenSum = await evenSumTask;
        // int oddSum = await oddSumTask;

        // Console.WriteLine($"Sum of even numbers: {evenSum}");
        // Console.WriteLine($"Sum of odd numbers: {oddSum}");
    }

    static async Task<int> JumlahBilGenap(List<int> numbers)
    {
        int sum = await Task.Run(() =>
        {
            return numbers.Where(x => x % 2 == 0).Sum();
        });
        return sum;
    }
    static async Task<int> JumlahBilGanjil(List<int> numbers)
    {
        int sum = await Task.Run(() =>
        {
            return numbers.Where(x => x % 2 != 0).Sum();
        });
        return sum;
    }
}