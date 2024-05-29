// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.Text.Json;
using System.Xml.Serialization;
using JSONSerializationDemo;

class Program
{
    static void Main(string[] args)
    {
        #region JSON
        // Human bella = new Human("Bella", 24, "Kediri");
        // Human alex = new Human("Alex", 22, "Kediri");
        // Human rizky = new Human("Rizky", 24, "Bandung");
        // Human fadl = new Human("Fadl", 24, "Jakarta");
        // Human dewi = new Human("Dewi", 25, "Pati");
        // Human wulan = new Human("Wulan", 29, "Bandung");
        // Human jun = new Human("Jun", 23, "Balikpapan");
        // Human yusa = new Human("Yusa", 26, "Tulungagung");

        // #region CREATE NEW HUMAN BY INPUT, LALU MASUK KE LIST
        // Console.WriteLine("Input name:");
        // string nameInput = Console.ReadLine();
        // Console.WriteLine("Input age:");
        // int ageInput = int.Parse(Console.ReadLine());
        // Console.WriteLine("Input Domisili:");
        // string domisiliInput = Console.ReadLine();
        // Human newHuman = new(nameInput, ageInput, domisiliInput);
        // #endregion


        // List<Human> bootcamp = new List<Human>(){
        //     bella,alex,rizky,fadl,dewi,wulan,jun,yusa,newHuman
        // };
        // //menyimpan list ke dalam JSON
        // string json = JsonSerializer.Serialize(bootcamp);
        // using (StreamWriter sw = new("file.json"))
        // {
        //     sw.Write(json);
        // }

        // #region  Deserialization
        // //Mmembaca file
        // string result;
        // using (StreamReader sr = new("file.json"))
        // {
        //     result = sr.ReadToEnd();
        // }

        // List<Human> bootcamp = JsonSerializer.Deserialize<List<Human>>(result);
        // foreach (var human in bootcamp)
        // {
        //     System.Console.WriteLine($"Name: {human.Name}");
        //     System.Console.WriteLine($"Age: {human.Age}");
        //     System.Console.WriteLine($"City: {human.Asal}");
        // }
        // #endregion
        #endregion

        #region XML
        Human bella = new Human("Bella", 24, "Kediri");
        Human alex = new Human("Alex", 22, "Kediri");
        Human rizky = new Human("Rizky", 24, "Bandung");
        Human fadl = new Human("Fadl", 24, "Jakarta");
        Human dewi = new Human("Dewi", 25, "Pati");
        Human wulan = new Human("Wulan", 29, "Bandung");
        Human jun = new Human("Jun", 23, "Balikpapan");
        Human yusa = new Human("Yusa", 26, "Tulungagung");

        #region CREATE NEW HUMAN BY INPUT, LALU MASUK KE LIST
        Console.WriteLine("Input name:");
        string nameInput = Console.ReadLine();
        Console.WriteLine("Input age:");
        int ageInput = int.Parse(Console.ReadLine());
        Console.WriteLine("Input Domisili:");
        string domisiliInput = Console.ReadLine();
        Human newHuman = new(nameInput, ageInput, domisiliInput);
        #endregion


        List<Human> bootcamp = new List<Human>(){
            bella,alex,rizky,fadl,dewi,wulan,jun,yusa,newHuman
        };
        //menyimpan list ke dalam JSON
        XmlSerializer xml = new XmlSerializer(typeof(List<Human>));
        using (StreamWriter sw = new("file.xml"))
        {
            xml.Serialize(sw, bootcamp);
        }
        #endregion

    }
}