namespace Project_B3;

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
    
    public override void DataKaryawan()
    {
        base.DataKaryawan();
        System.Console.WriteLine("Status Tetap");
    }
}
