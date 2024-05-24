namespace DestructorDemo;

public class Car
{
    public Car()
    {
        System.Console.WriteLine("Constructor are created");
    }

    ~Car()
    {
        System.Console.WriteLine("Destructor are called");
    }

}
