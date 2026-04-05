using JwtSample.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JwtSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private ITokenGeneratorServices _tokenGeneratorService;
        public LoginController(ITokenGeneratorServices tokenGeneratorService)
        {
            _tokenGeneratorService = tokenGeneratorService;
        }
        [HttpGet(Name = "Login")]
        public IActionResult Login(string email, string password)
        {
            /*my way
            if(DummyUsersData.GetAllUsers().Any(x => x.Email == email && x.Password == password))
            { }*/
            var accessToken = string.Empty;
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password)) 
            {
                return BadRequest("Email and password required");
            }
            var user = DummyUsersData.GetAllUsers().FirstOrDefault(x => x.Email == email);

            if(user == null)
            {
                return Unauthorized("Invalid email or password");
            }
            if (user.Password != password)
            {
                return Unauthorized("Invalid email or password");
            }
            {
                //Generate token

               accessToken = _tokenGeneratorService.GenerateToken(user, password);
            }

            return Ok(accessToken);
        }
    }
}
