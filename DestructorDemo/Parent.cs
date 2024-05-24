namespace DestructorDemo;

public class Parent:GrandParent
{
    ~Parent(){
        System.Console.WriteLine("Parent eliminated");
        System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
    }
}
