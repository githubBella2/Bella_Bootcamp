namespace Project_Inheritance;

public class KaryawanMagang : Karyawan
{
    public int gaji;
    public int banyakJam;

    public KaryawanMagang(string name, int age, int gaji, int banyakJam) : base(name, age)
    {
        this.gaji = gaji;
        this.banyakJam = banyakJam;
    }
    public int Salary(int gaji, int banyakJam)
    {
        return gaji * banyakJam;
    }
}
