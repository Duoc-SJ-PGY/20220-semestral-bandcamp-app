using Microsoft.AspNetCore.Mvc;

namespace TwitterAPI.Controllers;

public class UsuarioController : ControllerBase
{
    [HttpGet]
    [Route("api/usuario")]
    public IActionResult Get()
    {
        return Ok("Olá Mundo");
    }
}