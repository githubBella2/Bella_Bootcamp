namespace Kucing
{
    class Cat
    {
        string color;
        string species;
        int age;
        string favoriteFood;
        string catName;


        public Cat(string favFood, string catName)
        {
            favoriteFood = favFood;
            this.catName = catName;
            // this.favoriteFood=favoriteFood;
        }

        public void Eat()
        {
            Console.WriteLine("This cat " + catName + " eat " + favoriteFood);
        }

        public void PrintInfo(string nama)
        {
            Console.WriteLine(nama);
            

        }
        public void PrintInfo(string nama, string ffood)
        {
            Console.WriteLine(nama);
            Console.WriteLine(ffood);

        }

        int Add()
        {
            return 4;
        }
    }

}