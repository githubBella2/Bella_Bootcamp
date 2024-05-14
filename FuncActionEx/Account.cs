namespace FuncActionEx;

public class Account
{
    public string Username
    {
        get
        {
            if (_username != null)
            {
                return _username;
            }
            else
            {
                "No Empty";
            }


        }; set;
    }
    public string Password { get; set; }

    public int YearOfBirth { get; set; }

    // public Func<string, string> SetUsername =

}
