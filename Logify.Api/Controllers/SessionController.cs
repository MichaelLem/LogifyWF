using Microsoft.AspNetCore.Mvc;
using Logify.BizLayer;

namespace Logify.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class SessionController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
