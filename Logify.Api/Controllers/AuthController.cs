using Microsoft.AspNetCore.Mvc;
using Logify.Models;
using Logify.BizLayer;


namespace Logify.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        // GET: /api/auth/authenticate?userName=...&password=...
        // You can also send these in the body (shown in a note below), but this matches your request: 2 parameters.
        [HttpPost]
        public ActionResult<UserAccount> Authenticate([FromBody] UserAccount user)
        {
            UserAccount authenticatedUser = new UserAccount();
            Authenticate auth = new Authenticate();

            authenticatedUser = auth.Validate(user.Username, user.PasswordHash);

            // Return the UserAccount model directly as JSON
            return Ok(authenticatedUser);
        }

    }
}
