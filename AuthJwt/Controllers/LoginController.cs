using AuthJwt.Models;
using AuthJwt.Repository;
using AuthJwt.Services;
using Microsoft.AspNetCore.Mvc;

namespace AuthJwt.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public LoginController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost]
        public IActionResult Authenticate([FromBody] LoginModel model)
        {
            var user = _userRepository.GetUser(model.Email, model.Password);

            if (user == null)
                return NotFound(new { message = "Invalid credentials" });

            return Ok(TokenService.GenerateToken(user));
        }
        
    }
}