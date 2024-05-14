// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
//FUNCTION, ACTION
class Program
{
    static void Main(string[] args)
    {
        Func<int, int, int> Addtition = AddNumbers; //1
        System.Console.WriteLine(Addtition(2, 3)); //3

        Action<int, int> Addition2 = AddNumbers2;
        Addition2(2, 3);


        //Anonymous Method
        Func<int, int, int> addFunc2 = delegate (int x, int y) { return x + y; };
        Action<int, int> addAction2 = delegate (int x, int y) { System.Console.WriteLine(x + y); };
        // Lambda Expression
        Func<int, int, int> addFunc = (x, y) => x + y;
        Action<int, int> AddAction = (x, y) => System.Console.WriteLine(x + y);



    }

    //2
    private static int AddNumbers(int param1, int param2)
    {
        return param1 + param2;
    }
    private static void AddNumbers2(int param1, int param2)
    {
        System.Console.WriteLine(param1 + param2);
    }
}