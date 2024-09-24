using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WeLearnAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestAuthController : ControllerBase
    {
        [HttpGet("user")]
        [Authorize(Roles = "User")]
        public IActionResult TestUserAuth()
        {
            return Ok("Bạn đã được xác thực là người dùng.");
        }

        [HttpGet("admin")]
        [Authorize(Roles = "Admin")]
        public IActionResult TestAdminAuth()
        {
            return Ok("Bạn đã được xác thực là quản trị viên.");
        }

        [HttpGet("all")]
        [Authorize]
        public IActionResult TestAllAuth()
        {
            return Ok("Bạn đã được xác thực.");
        }
    }
}