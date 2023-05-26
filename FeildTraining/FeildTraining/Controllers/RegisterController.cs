using Microsoft.AspNetCore.Mvc;

namespace FeildTraining.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
