using Microsoft.AspNetCore.Mvc;
using OlympiadProgramming.BLL.Dto;
using OlympiadProgramming.BLL.Interfaces;
using OlympiadProgramming.Web.Interfaces;
using OlympiadProgramming.Web.Models.Requests;

namespace OlympiadProgramming.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IJWTTokenService _jWTTokenService;
        public AuthController(IUserService userService, IJWTTokenService jWTTokenService)
        {
            _userService = userService;
            _jWTTokenService = jWTTokenService;
        }

        [HttpPost("Login")]
        public IActionResult Login([FromBody] LoginRequest loginRequest)
        {
            if (loginRequest is null)
            {
                return BadRequest("Введите логин и пароль");
            }

            var user = _userService.GetUserByLoginAndPassword(loginRequest.Username
                                                            , loginRequest.Password);
            if (user is null)
            {
                return Unauthorized("Пользователя не существует");
            }

            var token = _jWTTokenService.Authenticate(user.UserName);

            return Ok(token);
        }

        [HttpPost("Register")]
        public IActionResult Register([FromBody] RegisterRequest registerRequest)
        {
            if (registerRequest is null)
            {
                return BadRequest("Не заполнены обязательные поля");
            }

            var createUserDto = new CreateUserDto
            {
                FirstName = registerRequest.FirstName,
                LastName = registerRequest.LastName,
                UserName = registerRequest.UserName,
                Password = registerRequest.Password
            };

            var user = _userService.RegisterUser(createUserDto);
            if (user is null)
            {
                return Unauthorized("Пользователя не существует");
            }

            var token = _jWTTokenService.Authenticate(user.UserName);

            return Ok(token);
        }
    }
}
