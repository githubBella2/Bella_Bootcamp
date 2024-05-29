using System.Dynamic;
using System.Runtime.Serialization;

namespace DataContractDemo;
[DataContract]
public class Player
{
    [DataMember]
    private string _name;
    [DataMember]
    private int _money;
    [DataMember]
    public int Gold { get; set; }
    [DataMember]
    public int Experience { get; set; }

    public Player(string name, int money, int gold, int exp)
    {
        _name = name;
        _money = money;
        Gold = gold;
        Experience = exp;
    }

    public string GetName()
    {
        return _name;
    }
    public int GetMoney(){
        return _money;
    }

}
