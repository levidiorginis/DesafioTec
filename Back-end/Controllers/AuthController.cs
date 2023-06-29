using Microsoft.AspNetCore.Mvc;
using Back_end.Util;
using Microsoft.AspNetCore.Authorization;

namespace Back_end.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [AllowAnonymous]
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