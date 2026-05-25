using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Logify.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        // GET: /api/auth/authenticate?userName=...&password=...
        // You can also send these in the body (shown in a note below), but this matches your request: 2 parameters.
        [HttpGet("Authenticate")]
        public IActionResult Authenticate(string userName, string password)
        {
            // Basic validation
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                return BadRequest(new { message = "userName and password are required." });
            }

            // DEMO ONLY: Replace with your real validation (DB lookup, Identity, etc.)
            var isValid =
                userName.Equals("manny", StringComparison.OrdinalIgnoreCase) &&
                password == "1234";

            if (!isValid)
            {
                return Unauthorized(new { message = "Invalid credentials." });
            }

            // Demo response (in real apps you'd return a JWT/token or set a cookie)
            return Ok(new
            {
                message = "Authenticated",
                userName = userName
            });
        }

    }
}
