using RefInOutSpace;
class Program
{
    static void Main(string[] args)
    {
        int refParameter = 7;
        int inParam = 23;
        int outParam;

        ExampleMethod(ref refParameter, in inParam, out outParam);
        System.Console.WriteLine(refParameter);
        System.Console.WriteLine(inParam);
        System.Console.WriteLine(outParam);

        int result;
        RefInOut.Multiply(1, 2, out result);
        System.Console.WriteLine($"Hasil perkalian adalah {result}");

        // int hasil;
        // RefInOut.Ball(7, 22 / 7, out hasil);
        // System.Console.WriteLine(hasil);


    }

    public static void ExampleMethod(ref int refParams, in int inParams, out int outParams)
    {
        refParams += 10;
        outParams = 50;
    }
}