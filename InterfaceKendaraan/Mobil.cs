namespace InterfaceKendaraan;

public class Mobil : Kendaraan, IKendaraan, IKendaraan2, IKendaraanSpeed
{
    public void Bergerak()
    {
        System.Console.WriteLine("Mobil bergerak dengan roda");
    }
    public void Berhenti()
    {
        System.Console.WriteLine("Mobil Berhenti dari interface");

    }
    public double Kecepatan(double jarak)
    {
        double hasil = jarak * 2;
        return hasil;

    }
    public override void Moving()
    {
        System.Console.WriteLine("Mobil dari abstract");
    }
    public override void Stop()
    {
        System.Console.WriteLine("Mobil stop dari Abstrak");
    }
    public override double Speed(double jarak, double waktu)
    {
        double hasil = jarak / waktu;
        return hasil;
    }

}
