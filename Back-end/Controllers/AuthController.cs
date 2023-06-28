using Microsoft.AspNetCore.Mvc;
using Back_end.Util;

namespace Back_end.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _config;

        public AuthController(IConfiguration config)
        {
            _config = config;
        }

        [HttpGet]
        public IActionResult Get([FromHeader] string login, [FromHeader] string password)
        {
            if (login == _config["Credentials:Login"] && password == _config["Credentials:Password"])
            {
                // Credenciais válidas, gera o token JWT
                var token = Generate.JwtToken(login);

                // Retorna o token na resposta
                return Ok(new { token });
            }

            return Unauthorized();
        }
    }
}