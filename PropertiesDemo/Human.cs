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

    private int _balance;

    public int Balance
    {
        get { return this._balance;}
        // private set;
        set
        {
            if (value > 0 && value <= 1000000)
            {
                // try
                // {
                System.Console.WriteLine("Silahkan mengajukan permintaan.");
                this._balance=value;
            }
            else
            {
                System.Console.WriteLine("Balance value is not allowed");
            }
        }

    }



    public int setBalance(int balance)
    {
        return Balance = balance;
    }
}
