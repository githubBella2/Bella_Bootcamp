using Microsoft.AspNetCore.Mvc;

namespace New.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ApiBaseController : ControllerBase
{
    protected readonly Database _db;
    public ApiBaseController(Database database)
    {
        _db = database;
    }
}
