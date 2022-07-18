using Microsoft.AspNetCore.Mvc;

namespace Aula11.Controllers;

[ApiController]
[Route("[controller]")]
public class CleberController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<CleberController> _logger;

    public CleberController(ILogger<CleberController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetExemplo")]
    public IEnumerable<string> Get()
    {
        var minhaLista = new List<string>{ "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"};
        return  minhaLista;
    }
}
