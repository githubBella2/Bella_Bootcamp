using Microsoft.AspNetCore.Mvc;
using mvcDemo.Data;
using mvcDemo.Models;

namespace mvcDemo.Controllers;

public class CategoryController : Controller
{
    private readonly MyDatabase _db;
    public IActionResult Index()
    {
        List<Category> categories = _db.Categories.ToList();
        return View(categories);
    }

    public CategoryController(MyDatabase db)
    {
        _db = db;
    }


}
