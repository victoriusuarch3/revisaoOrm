using Microsoft.AspNetCore.Mvc;

namespace ProjetoMercadoLivre.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public IActionResult OrmTestApi( int Id)
    {
        var usuario = _context.Usuarios.Find(id);
        return Ok(usuario);
    }

     [HttpGet("Other/{id}")]
    public IActionResult GetTeste(int id)
    {
        var usuarios = _context.Usuarios.Update;
        return Ok(usuarios);
    }
}