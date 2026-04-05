using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JwtSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {

        [HttpGet(Name = "GetAllUser")]
        public ActionResult<List<Users>> Get()
        {
            return DummyUsersData.GetAllUsers().ToList();
        }
    }
}
