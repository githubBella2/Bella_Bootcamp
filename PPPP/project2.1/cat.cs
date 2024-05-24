namespace hewandarat;

public class cat
{
	public string name;
	public int age;
	public string colour;
	
	public cat(string name, int age, string colour)
	{
		this.name = name;
		this.age = age;
		this.colour = colour;
	}
	
	public void meow()
	{
		Console.WriteLine("meow");
	}
	
	public void meow(string sound)
	{
		Console.WriteLine("meow" + sound);
	}
}
