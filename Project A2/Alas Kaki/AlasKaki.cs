namespace PenutupKaki;

public class AlasKaki
{
    public string jenis;
    public string warna;
    public int harga;
    public AlasKaki(string type, string color, int price)
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
}







