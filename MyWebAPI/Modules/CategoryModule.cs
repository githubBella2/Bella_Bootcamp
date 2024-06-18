using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MyWebAPI.Models;

namespace MyWebAPI.Modules;

public class CategoryModule
{
    private readonly Database _db;

    public CategoryModule(Database db)
    {
        _db = db;
    }

    public IEnumerable<Category> GetCategory()
    {
        return _db.Categories.ToList();
    }
   
    public bool Create(Category category)
    {
        _db.Categories.Add(category);
        int value = _db.SaveChanges();
        if (value > 0)
        {
            return true;
        }
        return false;
    }
}
