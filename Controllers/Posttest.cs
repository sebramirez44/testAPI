using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
namespace test2.Controllers;

[ApiController]
// aqui cambias la route a lo que quieras, [controller] es el nombre de la clase que es el controller
[Route("/")]
public class Posttest : ControllerBase
{

    [HttpPost(Name = "PostRequest")]
    public IActionResult Post()
    {
        return Ok();

    }
}
