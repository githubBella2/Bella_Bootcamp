namespace Project_B3;

public class Karyawan
{
    public string name;
    public int age;

    public Karyawan(string nama, int umur)
    {
        this.name = nama;
        this.age = umur;
    }
    public virtual void DataKaryawan()
    {
        if (age < 30)
        {
            System.Console.WriteLine($"{name} berusia {age}");
            System.Console.WriteLine("Old");
        }
        else
        {
            System.Console.WriteLine($"{name} berusia {age}");
            System.Console.WriteLine("Young");
        }
    }

}
