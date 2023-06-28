using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ExemploController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        // Lógica para retornar os dados em formato JSON
        return Ok(new { message = "Exemplo de resposta JSON" });
    }
}
