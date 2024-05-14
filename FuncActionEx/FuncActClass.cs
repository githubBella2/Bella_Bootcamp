namespace FuncActionEx;

public class FuncActClass
{
    public static Func<string, string> UbahKeKapital = nama => nama.ToUpper();
    public static void TampilkanNama(string nama)
    {
        string namaBaru= UbahKeKapital(nama);
        System.Console.WriteLine("Nama: "+namaBaru);
    }

}
