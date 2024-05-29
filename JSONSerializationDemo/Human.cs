namespace JSONSerializationDemo;

public class Human
{
    public string Name { get; set; }
    public int Age { get; set; }
    // public string Asal { get; private set; }
    public string Asal { get; set; }

    public Human(string name, int age, string asal)
    {
        Name = name;
        Age = age;
        Asal = asal;
    }
   
   public Human(){

   }
}
