using EntityFramework;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main(string[] args)
    {
        using (Northwind db = new())
        {
            bool status = db.Database.CanConnect();
            System.Console.WriteLine(status);

            List<Category> categories = db.Categories.ToList();
            foreach (var cat in categories)
            {
                System.Console.WriteLine($"Category id: {cat.CategoryID} | Category name: {cat.CategoryName} | Category description: {cat.Description}");
            }

            Category? category1 = db.Categories.Find(4);
            Category category2 = db.Categories.Where(c => c.CategoryID == 1).FirstOrDefault();
            Category searchSeafood = db.Categories.Where(c => c.CategoryName == "Seafood").FirstOrDefault();

            System.Console.WriteLine($"dd: {category2.CategoryName}");
            System.Console.WriteLine($"dd1: {category1.CategoryName}");
            System.Console.WriteLine($"dd2: {searchSeafood.CategoryName}");


            // BIKIN KATEGORI BARU
            // CREATE
            // Category category3 = new()
            // {
            //     CategoryName = "Sumanto1",
            //     Description = "Eat something"
            // };
            // db.Categories.Add(category3);
            // db.SaveChanges();

            // Category searchSumanto = db.Categories.Where(c => c.CategoryName == "Sumanto").FirstOrDefault();
            // var keySumanto = db.Categories.Find(12);
            // Category keySumanto = db.Categories.FirstOrDefaultAsync(c => c.CategoryID == 11);

            // System.Console.WriteLine($"dd1: {searchSumanto.CategoryName}");

            // UPDATE
            // Category keySumanto = db.Categories.Where(c => c.CategoryID == 18).FirstOrDefault();
            // var keySumanto = db.Categories.Find(18);
            // // System.Console.WriteLine(keySumanto.CategoryName);
            // if (keySumanto != null)
            // {
            //     keySumanto.CategoryName = "Yanto00";
            //     db.SaveChanges();
            //     // keySumanto.Description = "Eat fruits";
            // }

            // DELETE
            // if(keySumanto != null){
            //     db.Categories.Remove(keySumanto);
            //     db.SaveChanges();
            // }
            // var entityToDelete = db.Categories.Find(17);
            // if (entityToDelete != null)
            // {
            //     foreach (var relatedEntity in entityToDelete.CategoryID)
            //     {
            //         db.Categories.Remove(relatedEntity);
            //     }
            // }


            Product catAtProduct = db.Products.Where(p => p.CategoryID == 17).FirstOrDefault();
            if (catAtProduct != null)
            {

            }









        }
    }
}