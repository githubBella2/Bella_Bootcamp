namespace InterfaceKendaraan;

public class Mobil : Kendaraan, IShape
{
    public void Bergerak()
    {
        System.Console.WriteLine("Mobil bergerak dengan roda");
    }
    public override void Moving()
    {
        System.Console.WriteLine("Mobil dari abstract");
    }
}
