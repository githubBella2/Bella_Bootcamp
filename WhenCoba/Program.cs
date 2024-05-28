// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
class Program
{
    static async Task Main(string[] args)
    {
        Game game = new();
        await game.LoadLevelAsync();
    }

}

class Game
{
    public async Task LoadLevelAsync()
    {
        Task modelTask = LoadModelAsync();
        Task soundTask = LoadSoundAsync();
        Task textureTask = LoadTextureAsync();

        //nunggu hingga semua tugas selesai
        await Task.WhenAll(modelTask, soundTask, textureTask);
        //mulai level setelah semua task selesai
        StartLevel();
    }
    
   public async Task LoadModelAsync()
    {
        await Task.Delay(2000);
        System.Console.WriteLine("Model loaded");
    }
    public async Task LoadTextureAsync()
    {
        await Task.Delay(1500);
        System.Console.WriteLine("Texture loaded");
    }
    public async Task LoadSoundAsync()
    {
        await Task.Delay(1000);
        System.Console.WriteLine("Sound loaded");
    }
    public static void StartLevel()
    {
        System.Console.WriteLine("Level start! ");
    }
}


