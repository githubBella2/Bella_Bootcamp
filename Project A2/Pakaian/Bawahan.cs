namespace PakaianBawah;

public class Bawahan
{
    public string jenis;
    public string warna;
    public int harga;


    public Bawahan(string type, string color, int price)
    {
        jenis = type;
        warna = color;
        harga = price;
    }

    public void PrintInfo(string type, string color, int price)
    {
        Console.WriteLine(type);
        Console.WriteLine(color);
        Console.WriteLine(price);
    }

    public void PrintInfo(string type,  int price)
    {
        Console.WriteLine(type);
        
        Console.WriteLine(price);
    }

}
