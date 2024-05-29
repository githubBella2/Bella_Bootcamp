// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System.Runtime.Serialization.Json;
using DataContractDemo;

class Program
{
    static void Main(string[] args)
    {
        Player juan = new Player("Juan", 2000, 300, 1500);
        Player reno = new Player("Reno", 4000, 400, 4500);
        Player didi = new Player("Didi", 5000, 500, 8500);

        List<Player> players = new List<Player>()
        {
            juan, reno, didi
        };

        Dictionary<int, List<Player>> dictionary2 = new Dictionary<int, List<Player>>(){
        {1,players}
        };


        Dictionary<int, Player> dictionary = new Dictionary<int, Player>(){
           {1,juan},
           {2,reno},
           {3,didi},
        };

        DataContractJsonSerializer serializer = new(typeof(Dictionary<int, List<Player>>));
        DataContractJsonSerializer serializer2 = new(typeof(Dictionary<int, Player>));
        using (FileStream fs = new("players.json", FileMode.Create))
        {
            serializer.WriteObject(fs, dictionary2);
            serializer2.WriteObject(fs, dictionary);
        }

        #region INTERFACE

        #endregion

    }
}