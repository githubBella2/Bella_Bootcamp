namespace PropertiesDemo;

public class Human
{
    // field
    private int ID;

    public int GetID()
    {
        return ID;
    }

    public void SetID(int id)
    {
        ID = id;
    }
    // properties
    public int IDd { get; }
    public string Name { get; set; }

    public int Balance
    {
        get { };
        // private set;
        set
        {
            if (value >= 0 && value <= 1000000)
            {
                // try
                // {
                //     System.Console.WriteLine("Silahkan mengajukan permintaan.");
                // }
                // catch (System.Exception e)
                // {
                //     System.Console.WriteLine("Jangan hutang.");
                //     throw;
                // }
            }
            else
            {

            }
        }

    }



    public int setBalance(int balance)
    {
        return Balance = balance;
    }
}
