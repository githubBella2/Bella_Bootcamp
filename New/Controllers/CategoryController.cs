using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using New.DTOS;
using New.Models;

namespace New.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly Database _db;
    private readonly IMapper _map;


    public CategoryController(Database db, IMapper mapper)
    {
        _db = db;
        _map = mapper;
    }

    [HttpGet]
    public IActionResult GetCategory(){
        return Ok(_db.Categories.ToList());
    }
    [HttpPost]
    public IActionResult CreateCategoryDTO(CategoryDTO catDto){
        Category category = _map.Map<Category>(catDto);
        _db.Categories.Add(category);
        _db.SaveChanges();
        return Ok();
    }


}
