namespace Smartphone;

public class Phone
{
    string color;
    string brand;
    string type;
    int jumlahKamera;
    int ram;


    public Phone(string warna, string brand,
    string tipe, int jumKamera, int ramHp)
    {
        color = warna;
        this.brand = brand;
        type = tipe;
        jumlahKamera = jumKamera;
        ram = ramHp;

    }

    public void Deskripsi()
    {
        Console.WriteLine("Smartphone " + brand+type +" punya kamera "+jumlahKamera
        +" dan ram "+ ram+ "GB" );
    }

    public void DetailHp(string warna)
    {
        Console.WriteLine(warna);
    }

    public void DetailHp(string warna, int kamera)
    {
        Console.WriteLine(warna);
        Console.WriteLine(kamera);
    }


}
