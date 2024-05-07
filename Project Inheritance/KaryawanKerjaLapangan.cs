namespace Project_Inheritance;

public class KaryawanKerjaLapangan
{
    public int gaji;
    public int banyakHari;
    public int banyakJam;

    public KaryawanKerjaLapangan(int gaji, int banyakHari, int banyakJam)
    {
        this.gaji = gaji;
        this.banyakHari = banyakHari;
        this.banyakJam = banyakJam;
    }

    public int Salary()
    {
        return banyakHari * banyakJam * gaji;
    }

}
