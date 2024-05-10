namespace Params;

public class Calculator
{
    public int Add(params int[] numbers)
    {
        int sum = 0;
        foreach (int i in numbers)
        {
            sum += i;
        }
        return sum;

    }

    public int CalculatorString(params string[] numbersString)
    {
        int sum = 0;
        foreach (string i in numbersString)
        {
            int number = int.Parse(i);
            sum += number;
        }
        return sum;
    }
}
