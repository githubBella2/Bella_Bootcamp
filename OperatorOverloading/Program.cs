// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using OperatorOverloading;
class Program
{
    static void Main(string[] args)
    {
        BoxClass box1 = new(4, 4);
        BoxClass box2 = new(5, 7);

        BoxClass box3 = box1 + box2;
        System.Console.WriteLine(box3.Length);

        TimeClass t1 = new(10,30);
        TimeClass t2 = new(5,20);

        TimeClass result = t1-t2;
        System.Console.WriteLine("Jam: "+result.Hours 
        +"Menit: "+result.Minutes);

        // SampleCompare sp = new SampleCompare();
        // sp.CompareTo(null);
    }
}