namespace Project_Inheritance;

public class KaryawanTetap : Karyawan
{
    public int gaji;
    public KaryawanTetap(string name, int age, int gaji) : base(name, age)
    {
        this.gaji = gaji;
    }

    public void Salary(int gaji)
    {
        Console.WriteLine($"{gaji}");
    }
}
