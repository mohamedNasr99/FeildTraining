using Microsoft.AspNetCore.Mvc;

namespace Mama_Food.Controllers
{
    public class LogInController : Controller
    {
        public IActionResult LogIn()
        {
            return View();
        }
    }
}
