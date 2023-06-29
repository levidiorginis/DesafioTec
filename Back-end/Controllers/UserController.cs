using Microsoft.AspNetCore.Mvc;
using Back_end.Util;
using Back_end.Services;
using Microsoft.AspNetCore.Authorization;
using Back_end.Models;

namespace Back_end.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _userService.GetAll());
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _userService.Delete(id));
        }

        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            return Ok(await _userService.Create(user));
        }
    }
}