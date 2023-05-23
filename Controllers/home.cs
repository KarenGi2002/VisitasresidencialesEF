using Microsoft.AspNetCore.Mvc;

namespace Visitas_residenciales.Controllers;

[ApiController]
[Route("[Controller]")]
public class homeController: ControllerBase{

    VisitasContext dbcontext;

    public homeController(VisitasContext db){
        dbcontext=db;

    }

    [HttpGet]
    [Route("Conndb")]
    public IActionResult Conndb(){
        dbcontext.Database.EnsureCreated();
        return Ok();
    }
}