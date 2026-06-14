using Microsoft.AspNetCore.Mvc;
using TestProject.Services;
using WebApplication.DTOs;
using WebApplication.Services;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<UserDTO>> GetById(int id)
        {
            var user = await _service.GetById(id);
            return Ok(user);
        }
    }
}