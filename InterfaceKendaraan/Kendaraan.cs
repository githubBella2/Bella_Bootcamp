namespace InterfaceKendaraan;

public abstract class Kendaraan
{
    public abstract void Moving();
    public abstract void Stop();

    public abstract double Speed(double jarak, double waktu);

    // public abstract List<string> ListBagasi;
   
}
