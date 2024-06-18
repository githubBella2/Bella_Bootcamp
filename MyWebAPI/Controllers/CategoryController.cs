
using AutoMapper;
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
    private readonly IMapper _map;
    public CategoryController(Database db, IMapper map)
    {
        _db = db;
        _map = map;
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
        // Category categoryNew = new()
        // {
        //     CategoryName = category.CategoryName,
        //     Description = category.Description
        // };

        #region AUTO MAPPER
        Category category1 = _map.Map<Category>(category);
        // IEnumerable<Category>cat = _map.Map<IEnumerable<Category>>(collectionOfCategoryDTO); // 
        #endregion

        _db.Categories.Add(category1);
        // _db.Categories.Add(categoryNew);
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



