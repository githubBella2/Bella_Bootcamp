namespace Poject_A4;

public class GenericConstraintStruct<T> where T :struct
{        public T Message;
        public void GeneridMethodStruct(T Param1, T Param2)
        {
            System.Console.WriteLine($"Message: {Message}");
            System.Console.WriteLine($"Param1: {Param1}");
            System.Console.WriteLine($"Param2: {Param2}");
        }
    
}
