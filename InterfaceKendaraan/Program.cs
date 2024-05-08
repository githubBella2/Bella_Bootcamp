using InterfaceKendaraan;
class Program
{
    static void Main(string[] args)
    {
        Pesawat pesawat = new();
        pesawat.Bergerak();
        pesawat.Moving();
        pesawat.Stop();
        pesawat.Berhenti();
        double printSpeedPesawat = pesawat.Speed(10, 5);
        System.Console.WriteLine($"Speed Pesawat ABSTRAK {printSpeedPesawat}");
        double printSpeedPesawatInterface = pesawat.Kecepatan(400);
        System.Console.WriteLine($"Speed pesawat Interface {printSpeedPesawatInterface}");
        System.Console.WriteLine("-------------------------------------");

        Mobil mobil = new();
        mobil.Bergerak();
        mobil.Moving();
        mobil.Stop();
        mobil.Berhenti();

        double printSpeedMobil = mobil.Speed(10, 5);
        System.Console.WriteLine($"Speed Mobil ABSTRAK {printSpeedMobil}");

        double printSpeedInterface = mobil.Kecepatan(100);
        System.Console.WriteLine(printSpeedInterface);
    }
}