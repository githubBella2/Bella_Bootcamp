
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MyWebAPI.DTOS;
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

    // [HttpPost]
    // public IActionResult CreateCategory(Category category) //menambahkan kategori baru
    // {
    //     _db.Categories.Add(category);
    //     _db.SaveChanges();
    //     return Ok();
    // }

    // DTO
    [HttpPost]
    public IActionResult CreateCategoryDTO(CategoryDTO category) //menambahkan kategori baru
    {
        Category categoryNew = new()
        {
            CategoryName = category.CategoryName,
            Description=category.Description
        };
        _db.Categories.Add(categoryNew);
        _db.SaveChanges();
        return Ok();
    }

    [HttpPut]
    public IActionResult UpdateCategory(int id, Category category)
    {
        Category cat = _db.Categories.Find(id);
        if (cat == null)
        {
            return NotFound($"ID {id} not found.");
        }
        cat.CategoryName = category.CategoryName;
        cat.Description = category.Description;
        _db.SaveChanges();
        return Ok(cat);
    }

    [HttpDelete]
    public IActionResult DeleteCategory(int id)
    {
        Category cat = _db.Categories.Find(id);
        if (cat == null)
        {
            return NotFound($"ID {id} not found.");
        }
        _db.Remove(cat);
        _db.SaveChanges();
        return Ok(cat);
    }
}



