namespace Poject_A4;

public class GenericConstraint<T>
{
    public T Message;
    public void GenericConstraintMethod(T Param1, T Param2)
    {
        System.Console.WriteLine($"Message: {Message}");
        System.Console.WriteLine($"Param1: {Param1}");
        System.Console.WriteLine($"Param2: {Param2}");

    }
   
}
