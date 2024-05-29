class Program
{
    static void Main(string[] args)
    {
        using (FileStream fs = new("file.txt", FileMode.Create, FileAccess.Write))
        {
            string[] input = { "Saya adalah manusia", "Yang hidup di dunia", "Fana ini" };
            using (StreamWriter outputFile = new StreamWriter(fs))
            {

                foreach (var word in input)
                {
                    outputFile.WriteLine(word);
                }
            }
        }

        using (FileStream fs = new("file.txt", FileMode.Append, FileAccess.Write))
        {
            using (StreamWriter outputfile = new(fs))
            {
                outputfile.WriteLine("Saya suka memakan bakso");
            }
        }

        using (StreamReader inputFile = new("file.txt"))
        {
            System.Console.WriteLine(inputFile.ReadLine());
            System.Console.WriteLine(inputFile.ReadLine());
            System.Console.WriteLine(inputFile.ReadLine());
            System.Console.WriteLine(inputFile.ReadLine());
        }
    }
}