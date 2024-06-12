using NewEF2.Data;
using NewEF2.Models;

class Program
{
    static void Main(string[] args)
    {
        // READ ALL
        using (Northwind db = new())
        {
            bool status = db.Database.CanConnect();
            System.Console.WriteLine(status);

            List<Category> categories = db.Categories.ToList();
            foreach (var cat in categories)
            {
                System.Console.WriteLine($"Category id: {cat.CategoryID} | Category name: {cat.CategoryName} | Category description: {cat.Description}");
            }

            List<Category> categoriess = db.Categories.ToList();
            foreach (var cat in categoriess)
            {
                System.Console.WriteLine(cat.CategoryName);
            }
        }

        #region READ FILTER
        // READ FILTER
        using (Northwind db = new())
        {

            string filter = "Seafood";
            Category? returnData = db.Categories.Where(data => data.CategoryName == filter).FirstOrDefault();
            System.Console.WriteLine(returnData.Description);
        }
        using (Northwind db = new())
        {
            string filter = "Seafood";
            IQueryable<Category>? returnData = db.Categories.Where(data => data.CategoryName == filter);
            foreach (var category in returnData)
            {
                System.Console.WriteLine(category.Description);
            }
        }
        #endregion

        #region CREATE
        // using (Northwind db = new())
        // {
        //     Category category = new();
        //     category.CategoryName = "Durian";
        //     category.Description = "Enak bet";
        //     // Nambahin data
        //     db.Categories.Add(category);
        //     // db.Categories.AddRange(category); // jika punya collection/array/data banyak. Bs langsung add seluruh datanya.
        //     // Save DB
        //     db.SaveChanges();
        // }

        // using (Northwind db = new()) //Add Range
        // {
        //     Category category1 = new();
        //     category1.CategoryName = "Durian Malaysia";
        //     category1.Description = "Berduri";
        //     Category category2 = new();
        //     category2.CategoryName = "Semangka";
        //     category2.Description = "Hitam Hijau";
        //     // Nambahin data
        //     db.Categories.AddRange(category1,category2); // jika punya collection/array/data banyak. Bs langsung add seluruh datanya.
        //     // Save DB
        //     db.SaveChanges();
        // }
        #endregion

        #region UPDATE
        using (Northwind db = new())
        {
            // Category category = db.Categories.Where(data => data.CategoryName.Contains("Semangka")).FirstOrDefault();
            // category.Description = "Update deskripsi dari semangka";
            // db.SaveChanges();

            // ==FILTER BY ID==
            // Category category = db.Categories.Find(21);
            // category.Description = "Update deskripsi dari semangka by id";
            // db.SaveChanges();
        }
        #endregion

        #region DELETE
        using (Northwind db = new())
        {
            // ==FILTER BY ID==
            Product? product = db.Products.Find(21);
            db.Products.Remove(product);
            db.SaveChanges();
        }
        #endregion

    }
}