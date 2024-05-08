using InterfaceKendaraan;
class Program
{
    static void Main(string[] args)
    {
        Pesawat pesawat = new();
        pesawat.Bergerak();

        Mobil mobil = new();
        mobil.Bergerak();
        mobil.Moving();
    }
}