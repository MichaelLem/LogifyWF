using Microsoft.AspNetCore.Mvc;

namespace Logify.Api.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
