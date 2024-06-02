using System;
using Dictionary;

class Program{
    static void Main(string[] args)
    {
        GameController controller = new();
        controller.GameStart();
        var items = controller.GetListPlayers();
        // foreach(var item in items){
        //     Console.WriteLine(item.UserName);
        // }

        var items2 = controller.GetaToDict();
        var Fausta = controller.GetAPlayer("Fausta");
        foreach (KeyValuePair<IPlayer, List<Coordinate>> kvp in items2){
            Console.WriteLine(kvp.Key);
            var it = kvp.Value;
            foreach(var i in it){
                Console.WriteLine(i.Y);
            }
        }

        controller.GameProces();

        Console.WriteLine("=========================");
        var items3 = controller.GetaToDict();
        foreach (KeyValuePair<IPlayer, List<Coordinate>> kvp in items3){
            Console.WriteLine(kvp.Key);
            var it = kvp.Value;
            foreach(var i in it){
                Console.WriteLine(i.X.ToString(), i.Y);
            }
        }
    }

    public static void GameStart(){

    }

    public static void SaveDict(){

    }
}