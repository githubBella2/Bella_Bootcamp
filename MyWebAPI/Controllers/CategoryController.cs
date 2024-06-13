
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MyWebAPI.Models;

namespace MyWebAPI.Controllers;


[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly Database _db;
    public CategoryController(Database db)
    {
        _db = db;
    }


    [HttpGet]
    public IActionResult GetCategory()
    {
        // return Ok("Ini Kategori");
        return Ok(_db.Categories.ToList());
    }

    [HttpPost]
    public IActionResult PostCategory(Category category) //menambahkan kategori baru
    {
        _db.Categories.Add(category);
        _db.SaveChanges();
        return Ok();

    }
}



