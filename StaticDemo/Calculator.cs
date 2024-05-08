namespace StaticDemo;

public static class Calculator
{
    public static double Pi = 3.14;
    public static double Add(double a, double b)
    {
        return a + b;
    }
    public static double Substract(double a, double b)
    {
        return a - b;
    }
    public static double CelciusToFahrenheit(double celcius)
    {
        return (celcius * 9 / 5) + 32;
    }
}
