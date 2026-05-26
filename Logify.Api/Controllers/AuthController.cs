using Microsoft.AspNetCore.Mvc;
using Logify.Models;
using Logify.BizLayer;

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
        public ActionResult<UserAccount> Authenticate(string userName, string password)
        {
            UserAccount user = new UserAccount();
            Authenticate auth = new Authenticate();

            user = auth.Validate(userName, password);

            // Return the UserAccount model directly as JSON
            return Ok(user);
        }

    }
}
