namespace CalculatorTesting;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string GetFullName(Person person)
    {
        if (person == null)
        {
            return null;
        }
        else
        {
            return $"{person.FirstName} {person.LastName}";

        }
    }

    public  bool IsEvenNumber(int number)
    {
        if (number % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
