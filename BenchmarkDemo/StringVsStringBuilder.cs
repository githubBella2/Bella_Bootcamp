using System.Text;
using BenchmarkDotNet.Attributes;

namespace BenchmarkDemo;
[MemoryDiagnoser]
public class StringVsStringBuilder
{
    [Params(10,100,1000)]
    public int iterationNumber;
    // [Benchmark]
    public string MyString()
    {  
        string str = String.Empty;
        for (int i = 0; i < iterationNumber; i++)
        {
            str += i;
        }
        return str;
    }
    // [Benchmark]
    public string MyStringBuilder()
    {
        StringBuilder str = new();
        for (int i = 0; i < iterationNumber; i++)
        {
            str.Append(i);
        }
        return str.ToString();
    }

    [Benchmark]
    public void Data()
    {
        Dictionary<string, string> countries = new Dictionary<string, string>();
        countries.Add("ID", "Indonesia");
        countries.Add("US", "United States");
        countries.Add("JP", "Japan");
        foreach (KeyValuePair<string, string> kvp in countries)
        {
            Console.WriteLine($"Kode: {kvp.Key}, Nama: {kvp.Value}");
        }
    }
}
