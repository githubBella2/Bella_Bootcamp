namespace InterfaceKendaraan;

public class Pesawat : Kendaraan, IKendaraan, IKendaraan2, IKendaraanSpeed
{
  public void Bergerak()
  {
    System.Console.WriteLine("Pesawat bergerak dengan sayap.");
  }
  public void Berhenti()
  {
    System.Console.WriteLine("Pesawat berhenti dari interface");
  }

  public double Kecepatan(double jarak)
  {
    double hasil = jarak * 0.5;
    return hasil;
  }
  public override void Moving()
  {
    System.Console.WriteLine("Pesawat dari abstract");
  }
  public override void Stop()
  {
    System.Console.WriteLine("Pesawat stop dari abstract");
  }
  public override double Speed(double jarak, double waktu)
  {
    double hasil = (jarak + waktu) / 2;
    return hasil;

  }

}
