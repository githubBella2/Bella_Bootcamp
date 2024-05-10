namespace Poject_A4;

public class GenericClass<T1, T2>
{
    public T1 Message;
    public void GenericMethod(T1 Name, T1 Location, T2 Age)
    {
        System.Console.WriteLine($"Message: {Message}");
        System.Console.WriteLine($"Name:    {Name}");
        System.Console.WriteLine($"Location:    {Location}");
        System.Console.WriteLine($"Age: {Age}");
    }

    public void GenericMethodParameter<T1, T2>(T1 Param1, T2 Param2)
    {
        System.Console.WriteLine($"Parameter T1 type:{typeof(T1)}\n Parameter T2 type: {typeof(T2)}");
        System.Console.WriteLine($"Parameter1: {Param1} :Parameter2: {Param2}");
    }


    

    

}
