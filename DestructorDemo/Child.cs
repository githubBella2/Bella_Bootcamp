namespace DestructorDemo;

public class Child : Parent
{
    ~Child()
    {
        System.Console.WriteLine("Child eliminated");
        System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
    }
}
