namespace Params;

public class Greet
{
    public void Menyapa(params string[] nama)
    {
        string hasil;
        foreach (string i in nama)
        {
            System.Console.WriteLine($"Hello {i}");
        }
    }
}
