using Project_Inheritance;
class Program
{
    static void Main(string[] args)
    {
        Karyawan kar = new Karyawan("Amanda", 28);
        KaryawanTetap karTetap = new KaryawanTetap("Bayu", 44, 5000000);
        KaryawanMagang karMagang = new KaryawanMagang("Agung", 33, 10000, 7);

        karTetap.Salary(karTetap.gaji);
        int printGajiMmagang = karMagang.Salary(karMagang.gaji, karMagang.banyakJam);
        Console.WriteLine(printGajiMmagang);
        // printgajikaryawanpkl
    }
}