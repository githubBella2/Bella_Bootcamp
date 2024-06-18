using Microsoft.AspNetCore.Mvc;
using MyWebAPI.Controllers;

public class ProductController:ApiBaseController{
    private readonly Database database;

    public ProductController(Database database) : base(database)
    {
        
    }
}