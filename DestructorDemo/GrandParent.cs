namespace DestructorDemo;

public class GrandParent
{
    // suicide method
    ~GrandParent()
    {
        System.Console.WriteLine("Grandparent eliminated");
        System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
    }
}
