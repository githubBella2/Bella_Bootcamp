namespace InterfaceKendaraan;

public class Pesawat : Kendaraan, IShape
{
  public void Bergerak()
  {
    System.Console.WriteLine("Pesawat bergerak dengan sayap.");
  }
  public override void Moving()
  {
    System.Console.WriteLine("Pesawat dari abstract");
  }
}
