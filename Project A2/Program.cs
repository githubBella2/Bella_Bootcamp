// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using Smartphone;
using PakaianAtas;
using PakaianBawah;
using PenutupKaki;
class Program
{
    static void Main()
    {
        Phone hp = new Phone("White","Samsung","Y12",3,16);

        // hp.Deskripsi();
        // hp.DetailHp("Hitam");
        // hp.DetailHp(hp.color);
        Atasan pakaianAtas= new Atasan("Kemeja","Orange",150000);
        Bawahan pakaianBawah = new Bawahan ("Rok","Biru",200000);
        AlasKaki alasKaki= new AlasKaki("Sepatu","Putih",200000);
        pakaianAtas.PrintInfo(pakaianAtas.jenis,pakaianAtas.warna);
        pakaianBawah.PrintInfo(pakaianBawah.jenis, pakaianBawah.harga);
        alasKaki.PrintInfo(alasKaki.jenis,alasKaki.warna, alasKaki.harga);
    }
}