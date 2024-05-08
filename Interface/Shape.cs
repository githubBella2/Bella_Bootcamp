namespace Interface;

public class Shape
{
    public abstract void Drawing();

    public void ChangeColor(string color){
        System.Console.WriteLine("Color change to "+ color);
    }
}
