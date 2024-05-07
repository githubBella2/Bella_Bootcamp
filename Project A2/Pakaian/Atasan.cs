namespace PakaianAtas;
public class Atasan
{
    public string jenis;
    public string warna;
    public int harga;

    public Atasan(string type, string color, int price)
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

    public void PrintInfo(string type, string color)
    {
        Console.WriteLine(type);
        Console.WriteLine(color);
        
    }

}


