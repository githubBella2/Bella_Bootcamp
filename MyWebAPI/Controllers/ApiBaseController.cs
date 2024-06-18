using Microsoft.AspNetCore.Mvc;

namespace MyWebAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ApiBaseController : ControllerBase
{
    protected readonly Database db;
    public ApiBaseController(Database database)
    {
        db = database;
    }
}
